#include <Wire.h>
#include <Arduino.h>
#include "trafficLight.h"
#include "communicationI2C.h"
unsigned long previousMillis = 1000;
long interval = 5000;
/*-------------------------------------------------------------*/
// COM5
// This library connects the Arduino to a device with I2C
// protocol. It is also a master.
//
//
#define ADDRESS (11)

/*-------------------------------------------------------------*/
void start_connection()
{
  Wire.begin(ADDRESS);
}

void slave_recieve_request()
{

  Wire.onReceive(recieveEvent); // register event
}


void recieveEvent(int recievedByte)
{
//  unsigned long currentMillis = millis();
  if (Wire.available())
  {
    recievedByte = Wire.read();
    Serial.println(recievedByte);
  }
//  if (currentMillis - previousMillis >= interval)
//  {
//    previousMillis = currentMillis;
    if (recievedByte == 0)
    { //Alarm
      modes(recievedByte);
      slave_send_request(2);
    }

     if (recievedByte == 49)
    { //Red
      Serial.println("Red");
      modes(recievedByte);
      slave_send_request(3);//51
    }
    /*
      if (recievedByte == 50)
      { //Orange
         Serial.println("Orange");
        modes(recievedByte);
        slave_send_request(2);
      }
    */
    if (recievedByte == 51)
    { //Green
      Serial.println("Green");
      modes(recievedByte);
      slave_send_request(1);//49
    }
//  }

}

void slave_send_request(int requestOtherMode)
{

  if (requestOtherMode == 1) {
    Wire.onRequest(requestEventRed);
  }
  if (requestOtherMode == 2) {
    Wire.onRequest(requestEventOrange);
  }
  if (requestOtherMode == 3) {
    Wire.onRequest(requestEventGreen);
  }

}

void requestEventRed() {
  Wire.write(49);
}
void requestEventOrange() {
  Wire.write(50);
}
void requestEventGreen() {
  Wire.write(51);
}



/*void slave_recieve_request_ping()
  {
  Wire.onReceive(recieveEventPing);
  }


  void recieveEventPing(int recievedByte)
  {
  int counter = 0;
  char recievedMessage[] = "";

  if (Wire.available())
  {

    char incomingChar = Wire.read();

    recievedMessage[counter] = incomingChar;

    counter ++;

  }
  Serial.println(recievedMessage);
  }*/


