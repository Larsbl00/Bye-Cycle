#include <Wire.h>
#include <Arduino.h>
#include "trafficLight.h"
#include "communicationI2C.h"
unsigned long previousMillis = 1000;
long timer = 5000;

#define ADDRESS (11)

void start_connection()
{
  Wire.begin(ADDRESS);
}

void slave_recieve_request()
{
  Wire.onReceive(recieveEvent); // register event
}


void recieveEvent(char recievedByte)
{
  unsigned long currentMillis = millis();
  
  if (Wire.available())
  {
    recievedByte = Wire.read();
    Serial.println(recievedByte);
  }
  if (currentMillis - previousMillis >= timer)
  {
    previousMillis = currentMillis;
    if (recievedByte == 'R')//49 is Red
    { //Red
      Serial.println("Red");
      modes(recievedByte);
      slave_send_request('G');//51
    }
    if (recievedByte == 'G')//51 is green
    { //Green
      Serial.println("Green");
      modes(recievedByte);
      slave_send_request('R');//49
    }
  }

}

void slave_send_request(char requestOtherMode)
{
  if (requestOtherMode == 'R') {
    Wire.onRequest(requestEventRed);
  }
  if (requestOtherMode == 'G') {
    Wire.onRequest(requestEventGreen);
  }
}

void requestEventRed() {
  Wire.write('R');
}
void requestEventGreen() {
  Wire.write('G');
}

