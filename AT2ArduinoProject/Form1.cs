using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;
using System.Threading;

namespace AT2ArduinoProject
{
    public partial class FormIoT : Form
    {
        private SerialPort arduinoPort = new SerialPort(); // creat SerialPort
        private string selectedPort;
        private int maxTemp = 30; // default max Temperature
        private string tempOut; // variables for data
        private string tempIn;
        private string humi;
        private string light;
        int comTempIn; // variable for bars
        int comTempOut;
        int comHumi;

        public FormIoT()
        {
            InitializeComponent();
        }
        // Method for when load the form
        private void FormIoT_Load(object sender, EventArgs e)
        {
            // find ports opened and lists in the combobox
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPort.Items.Add(port);
            }
            // lists option of max temperature
            for (int i = 25; i <= 30; i++)
            {
                comboBoxTMax.Items.Add(i);
            }

            toolStripStatusLabel2.Text = "Form loaded"; // display status
        }
        // Method for Red LED toggle
        private void buttonRedLED_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Red lignt control"; // display status
            try
            {
                arduinoPort.Write("T");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Method to Open Port
        private void buttonPort_Click(object sender, EventArgs e)
        {
            if (arduinoPort.IsOpen == false)
            {
                selectedPort = comboBoxPort.Text;
                arduinoPort.PortName = selectedPort;    //Port No. with Ardurino
                arduinoPort.BaudRate = 9600;       //speed
                arduinoPort.RtsEnable = true;   // this is the KEY that I spend whole week
                //to solve the problem can not receive data from Arduino
                try
                {
                    arduinoPort.Open();                 // Port open
                    toolStripStatusLabel2.Text = "Port Opened"; // display status
                    beep(); // give a sound when port opened
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: ", ex);
                }
            }
            else
            {
                beep2(); // give error sound when trying to open port when port is opened
                toolStripStatusLabel2.Text = "Port already Opened"; // display status
            }

            backgroundWork(); // start receive data from Arduino
        }
        // Method to receive data from Arduino and display data in the textboxes and handle Max temperature
        // asynchronous Method; workign seperately with other functions of the Form
        private async void backgroundWork()
        {
            string[] data; // variable for split saved string data 
            // If port is closed, Open again
            if (!arduinoPort.IsOpen)
            {
                arduinoPort.Open();
            }
            // eternal loop to receive data continutely
            for ( ; ; )
            {
                // Give delay to receive data 5seconds
                await Task.Run(() =>
                {
                    Thread.Sleep(500); // millisecond
                });
                // Receive Data and Display Data ########################################
                try
                {
                    toolStripStatusLabel2.Text = "background working"; // display status

                    data = arduinoPort.ReadExisting().Split(','); // split data by ","
                    humi = data[0];
                    tempIn = data[1];
                    tempOut = data[2];
                    light = data[3];
                    // display in the textboxes
                    textBoxInHumi.Text = humi;
                    textBoxInTemp.Text = tempIn;
                    textBoxOutTemp.Text = tempOut;
                    // convert string to int to dispaly on the bars
                    try
                    {
                        comTempIn = (int)(float.Parse(tempIn) * 100);
                        comTempOut = (int)float.Parse(tempOut);
                        comHumi = (int)float.Parse(humi);
                    }
                    catch { }
                    // display on the bars
                    progressBarOutTemp.Value = comTempOut;
                    progressBarInTemp.Value = comTempIn / 100;
                    progressBarHumi.Value = comHumi;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                // ######################################################################
                // Check room Temperature with Max temperature (default is 30)
                if ((maxTemp * 100) < comTempIn)
                {
                    try
                    {
                        arduinoPort.Write("W"); // send Alert beep(I killed now as too noisey) and Red light blinking
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        // Method for setting Max Temperature
        private void buttonTMax_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTMax.Visible) // If combobox is visible, set the value of on the list
                {
                    maxTemp = int.Parse(comboBoxTMax.Text);
                }
                else if (textBoxMaxTemp.Visible) // If combobox is invisible, set the manual value of in the textbox
                {
                    maxTemp = int.Parse(textBoxMaxTemp.Text);
                }
                else
                {
                    MessageBox.Show("Invalid input for Max Temperature"); // display wrong input
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Method for Buzzor
        private void beep()
        {
            try
            {
                arduinoPort.Write("5");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Method for Error Buzzor
        private void beep2()
        {
            try
            {
                arduinoPort.Write("E");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Method to close port when form closing
        private void FormIoT_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                arduinoPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Method to change combobox and textbox
        private void buttonManual_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "box changed"; // display status
            if (textBoxMaxTemp.Visible)
            {
                textBoxMaxTemp.Visible = false;
                comboBoxTMax.Visible = true;
            } else
            {
                textBoxMaxTemp.Visible = true;
                comboBoxTMax.Visible = false;
            }
            if (buttonManual.Text == "Set Manual")
            {
                buttonManual.Text = "Choose in list";
            } else
            {
                buttonManual.Text = "Set Manual";
            }
        }
        // Method to change RGB Color by clicking radio button
        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Green lignt"; // display status
            try
            {
                arduinoPort.Write("O"); // Turn off RGB light first
                arduinoPort.Write("G"); // Turn on Green light
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Method to change RGB Color by clicking radio button
        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Red lignt"; // display status
            try
            {
                arduinoPort.Write("O"); // Turn off RGB light first
                arduinoPort.Write("R"); // Turn on Red light
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Method to change RGB Color by clicking radio button
        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Blue lignt"; // display status
            try
            {
                arduinoPort.Write("O"); // Turn off RGB light first
                arduinoPort.Write("B"); // Turn on Blue light
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Method to change RGB Color by clicking radio button
        private void radioButtonOff_CheckedChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "lignt Off"; // display status
            try
            {
                arduinoPort.Write("O"); // Turn off RGB light
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
