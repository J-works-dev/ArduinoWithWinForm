
namespace AT2ArduinoProject
{
    partial class FormIoT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPort = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.textBoxOutTemp = new System.Windows.Forms.TextBox();
            this.textBoxInTemp = new System.Windows.Forms.TextBox();
            this.textBoxInHumi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTMax = new System.Windows.Forms.ComboBox();
            this.buttonTMax = new System.Windows.Forms.Button();
            this.buttonRedLED = new System.Windows.Forms.Button();
            this.buttonManual = new System.Windows.Forms.Button();
            this.textBoxMaxTemp = new System.Windows.Forms.TextBox();
            this.progressBarOutTemp = new System.Windows.Forms.ProgressBar();
            this.progressBarInTemp = new System.Windows.Forms.ProgressBar();
            this.progressBarHumi = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPort);
            this.groupBox1.Controls.Add(this.comboBoxPort);
            this.groupBox1.Location = new System.Drawing.Point(24, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(109, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // buttonPort
            // 
            this.buttonPort.Location = new System.Drawing.Point(5, 57);
            this.buttonPort.Name = "buttonPort";
            this.buttonPort.Size = new System.Drawing.Size(99, 23);
            this.buttonPort.TabIndex = 1;
            this.buttonPort.Text = "Connect";
            this.buttonPort.UseVisualStyleBackColor = true;
            this.buttonPort.Click += new System.EventHandler(this.buttonPort_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(5, 22);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(99, 21);
            this.comboBoxPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonOff);
            this.groupBox2.Controls.Add(this.radioButtonBlue);
            this.groupBox2.Controls.Add(this.radioButtonRed);
            this.groupBox2.Controls.Add(this.radioButtonGreen);
            this.groupBox2.Location = new System.Drawing.Point(24, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Location = new System.Drawing.Point(6, 125);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(45, 17);
            this.radioButtonOff.TabIndex = 3;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "OFF";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            this.radioButtonOff.CheckedChanged += new System.EventHandler(this.radioButtonOff_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(6, 92);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(6, 60);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(6, 28);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(54, 17);
            this.radioButtonGreen.TabIndex = 0;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // textBoxOutTemp
            // 
            this.textBoxOutTemp.Location = new System.Drawing.Point(302, 41);
            this.textBoxOutTemp.Name = "textBoxOutTemp";
            this.textBoxOutTemp.ReadOnly = true;
            this.textBoxOutTemp.Size = new System.Drawing.Size(73, 20);
            this.textBoxOutTemp.TabIndex = 2;
            // 
            // textBoxInTemp
            // 
            this.textBoxInTemp.Location = new System.Drawing.Point(302, 85);
            this.textBoxInTemp.Name = "textBoxInTemp";
            this.textBoxInTemp.ReadOnly = true;
            this.textBoxInTemp.Size = new System.Drawing.Size(73, 20);
            this.textBoxInTemp.TabIndex = 3;
            // 
            // textBoxInHumi
            // 
            this.textBoxInHumi.Location = new System.Drawing.Point(302, 129);
            this.textBoxInHumi.Name = "textBoxInHumi";
            this.textBoxInHumi.ReadOnly = true;
            this.textBoxInHumi.Size = new System.Drawing.Size(73, 20);
            this.textBoxInHumi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Outside Temp (LM35)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inside Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inside Humidity (DHT11)";
            // 
            // comboBoxTMax
            // 
            this.comboBoxTMax.FormattingEnabled = true;
            this.comboBoxTMax.Location = new System.Drawing.Point(277, 198);
            this.comboBoxTMax.Name = "comboBoxTMax";
            this.comboBoxTMax.Size = new System.Drawing.Size(97, 21);
            this.comboBoxTMax.TabIndex = 8;
            // 
            // buttonTMax
            // 
            this.buttonTMax.Location = new System.Drawing.Point(165, 198);
            this.buttonTMax.Name = "buttonTMax";
            this.buttonTMax.Size = new System.Drawing.Size(106, 23);
            this.buttonTMax.TabIndex = 9;
            this.buttonTMax.Text = "Temp Max";
            this.buttonTMax.UseVisualStyleBackColor = true;
            this.buttonTMax.Click += new System.EventHandler(this.buttonTMax_Click);
            // 
            // buttonRedLED
            // 
            this.buttonRedLED.BackColor = System.Drawing.Color.Red;
            this.buttonRedLED.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedLED.ForeColor = System.Drawing.Color.White;
            this.buttonRedLED.Location = new System.Drawing.Point(165, 261);
            this.buttonRedLED.Name = "buttonRedLED";
            this.buttonRedLED.Size = new System.Drawing.Size(209, 38);
            this.buttonRedLED.TabIndex = 10;
            this.buttonRedLED.Text = "Red LED Toggle";
            this.buttonRedLED.UseVisualStyleBackColor = false;
            this.buttonRedLED.Click += new System.EventHandler(this.buttonRedLED_Click);
            // 
            // buttonManual
            // 
            this.buttonManual.Location = new System.Drawing.Point(277, 225);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(99, 23);
            this.buttonManual.TabIndex = 11;
            this.buttonManual.Text = "Set Manual";
            this.buttonManual.UseVisualStyleBackColor = true;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // textBoxMaxTemp
            // 
            this.textBoxMaxTemp.Location = new System.Drawing.Point(277, 198);
            this.textBoxMaxTemp.Name = "textBoxMaxTemp";
            this.textBoxMaxTemp.Size = new System.Drawing.Size(97, 20);
            this.textBoxMaxTemp.TabIndex = 12;
            this.textBoxMaxTemp.Visible = false;
            // 
            // progressBarOutTemp
            // 
            this.progressBarOutTemp.Location = new System.Drawing.Point(188, 66);
            this.progressBarOutTemp.Name = "progressBarOutTemp";
            this.progressBarOutTemp.Size = new System.Drawing.Size(186, 7);
            this.progressBarOutTemp.TabIndex = 13;
            // 
            // progressBarInTemp
            // 
            this.progressBarInTemp.Location = new System.Drawing.Point(188, 110);
            this.progressBarInTemp.Name = "progressBarInTemp";
            this.progressBarInTemp.Size = new System.Drawing.Size(186, 7);
            this.progressBarInTemp.TabIndex = 14;
            // 
            // progressBarHumi
            // 
            this.progressBarHumi.Location = new System.Drawing.Point(188, 154);
            this.progressBarHumi.Name = "progressBarHumi";
            this.progressBarHumi.Size = new System.Drawing.Size(186, 7);
            this.progressBarHumi.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // FormIoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 333);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBarHumi);
            this.Controls.Add(this.progressBarInTemp);
            this.Controls.Add(this.progressBarOutTemp);
            this.Controls.Add(this.textBoxMaxTemp);
            this.Controls.Add(this.buttonManual);
            this.Controls.Add(this.buttonRedLED);
            this.Controls.Add(this.buttonTMax);
            this.Controls.Add(this.comboBoxTMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInHumi);
            this.Controls.Add(this.textBoxInTemp);
            this.Controls.Add(this.textBoxOutTemp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormIoT";
            this.Text = "IoT Prototype";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIoT_FormClosing);
            this.Load += new System.EventHandler(this.FormIoT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPort;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.TextBox textBoxOutTemp;
        private System.Windows.Forms.TextBox textBoxInTemp;
        private System.Windows.Forms.TextBox textBoxInHumi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTMax;
        private System.Windows.Forms.Button buttonTMax;
        private System.Windows.Forms.Button buttonRedLED;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.TextBox textBoxMaxTemp;
        private System.Windows.Forms.ProgressBar progressBarOutTemp;
        private System.Windows.Forms.ProgressBar progressBarInTemp;
        private System.Windows.Forms.ProgressBar progressBarHumi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

