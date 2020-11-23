#include "DHT.h"
#define DHTPIN 4
#define DHTTYPE DHT11

DHT dht(DHTPIN, DHTTYPE);

const int sw1 = 2;
const int sw2 = 3;
//const int DHT11 = 4;
const int light = A1;
const int lm35 = A2;
const int rotDial = A0;
const int ledBlue = 13;
const int ledRed = 12;
const int ledRGB_blue = 11;
const int ledRGB_green = 10;
const int ledRGB_red = 9;
const int buzzer = 5;
int sw = 0;
unsigned long delayStart = 0;
bool delayRunning = false;
int setRotation = 0;

void setup() {
  Serial.begin(9600);
  dht.begin();
  pinMode(buzzer, OUTPUT);
  pinMode(ledRGB_red, OUTPUT);
  pinMode(ledRGB_green, OUTPUT);
  pinMode(ledRGB_blue, OUTPUT);
  pinMode(ledRed, OUTPUT);
  pinMode(ledBlue, OUTPUT);
  pinMode(sw1, INPUT);
  pinMode(sw2, INPUT);
  pinMode(lm35, INPUT);
  pinMode(light, INPUT);
  pinMode(rotDial, INPUT);
}

void loop() {
  float humi = dht.readHumidity(); // DHT11
  float tempIn = dht.readTemperature(); // DHT11
  int rotationVal = analogRead(rotDial); // Rotation Dial
  float data[3];
  // LM35
  int rawVal;
  float tempOut;
  rawVal = analogRead(lm35);
  tempOut = (rawVal * 4.88) * 0.1;
  // Send data
  if (isnan(humi)) {
    humi = 0.0;
  } else if (isnan(tempIn)) {
    tempIn = 0.0;
  } else if (isnan(tempOut)) {
    tempOut = 0.0;
  } else {
    String data = String(humi) + "," + String(tempIn) + "," + String(tempOut) + "," + String(rotationVal);
    Serial.println(data);
    data = "";
  }
  // Light control
  int lightVal = analogRead(light);
  if (lightVal < 500) {
    digitalWrite(ledBlue, HIGH);
    delayRunning = true;
    delayStart = millis();
  }
  if (delayRunning && ((millis() - delayStart) >= 5000)) {
    delayRunning = false;
    digitalWrite(ledBlue, LOW);
  }
  // Mood light
  int red = 0;
  int green = 0;
  int blue = 0;
  if (!(rotationVal > (setRotation - 10) && rotationVal < (setRotation + 10))) {
    RGB_light(0, 0, 0);
    if (rotationVal > 10) {
      if (rotationVal > 256) {
        if (rotationVal > 512) {
          if (rotationVal > 768) {
            red = rotationVal - 768;
            if (red > 255) {
              red = 255;
            }
            green = 0;
            blue = 255;
          } else {
            red = 0;
            green = 255 - (rotationVal - 512);
            blue = rotationVal -512;
          }
        } else {
          red = 255 - (rotationVal - 256);
          green = 255;
          blue = 0;
        }
      } else {
        red = 255;
        green = rotationVal;
        blue = 0;
      }
    } else {
      red = 0;
      green = 0;
      blue = 0;
    }
    RGB_light(red, green, blue);
  }
  
  // Get Order from Visual Studio
  char ch = Serial.read();
  // Doing As Order from Visual Studio
  // Red light
  if (ch == 'T') {
    if (sw == 0) {
      digitalWrite(ledRed, HIGH);
      sw = 1;
    } else {
      digitalWrite(ledRed, LOW);
      sw = 0;
    }
  }
  // Blue light on
  if (ch == '2') {
    digitalWrite(ledBlue, HIGH);
  }
  // Blue light off
  if (ch == '3') {
    digitalWrite(ledBlue, LOW);
  }
  // Red RGB light
  if (ch == 'R') {
    digitalWrite(ledRGB_red, HIGH);
    setRotation = rotationVal;
  }
  // Green RGB light
  if (ch == 'G') {
    digitalWrite(ledRGB_green, HIGH);
    setRotation = rotationVal;
  }
  // Blue RGB light
  if (ch == 'B') {
    digitalWrite(ledRGB_blue, HIGH);
    setRotation = rotationVal;
  }
  // RGB light Off
  if (ch == 'O') {
    RGB_light(0, 0, 0);
    setRotation = rotationVal;
  }
  // Error Buzzor
  if (ch == 'E') {
    tone(buzzer, 100);
    delay(100);
    tone(buzzer, 300);
    delay(50);
    noTone(buzzer);
  }
  // Beep Buzzor
  if (ch == '5') {
    tone(buzzer, 150);
    delay(50);
    noTone(buzzer);
  }
  // Temperature Worning
  if (ch == 'W') {
//    tone(buzzer, 1000);
    digitalWrite(ledRed, HIGH);
    delay(100);
//    tone(buzzer, 200);
    digitalWrite(ledRed, LOW);
    delay(50);
//    tone(buzzer, 1000);
    digitalWrite(ledRed, HIGH);
    delay(100);
//    tone(buzzer, 200);
    digitalWrite(ledRed, LOW);
    delay(50);
//    tone(buzzer, 1000);
    digitalWrite(ledRed, HIGH);
    delay(100);
//    tone(buzzer, 200);
    digitalWrite(ledRed, LOW);
    delay(50);
    noTone(buzzer);
  }
}
// Method for RGB light
void RGB_light(int red_light_value, int green_light_value, int blue_light_value)
 {
  analogWrite(ledRGB_red, red_light_value);
  analogWrite(ledRGB_green, green_light_value);
  analogWrite(ledRGB_blue, blue_light_value);
}
