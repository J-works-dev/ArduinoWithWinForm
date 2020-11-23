# ArduinoWithWinForm
Practice of Arduino with C# Windows Form.

Assignment for Scripting class

Function requirements
1. Read and display the current inside temperature and humidity. Use the Arduino Humidity
sensor DHT11 for this task.
2. Read and display the current outside temperature; use the single Temperature Sensor LM35 for
this task.
3. Control the Red LED using a single toggle button, which clicks once for on and once for off.
4. Automatic timer to turn off lights; create a simple method which updates a variable to turn off
the Blue LED after 10 seconds. (Point 4 and 5 can be combined)
5. Turn off lights when the room is too bright, uses the light sensitive LED to control the
illumination of the Blue LED. The Blue LED will turn on when the Light A1 is covered (Dark) and
turn off when under normal daylight. (Point 4 and 5 can be combined)
6. Sound a warning when the temperature is above a set comfort maximum. Use the DHT11
Sensor and Buzzer; set a temperature maximum that can be easily demonstrated (ie Temp
between 25-28C).
7. Control mood light by manually adjusting the variable dial (Rotation A0). This feature will use
the RGB LED and the Rotation Sensor. This could also be controlled by a radio button group (or
similar control) on the Windows Form
