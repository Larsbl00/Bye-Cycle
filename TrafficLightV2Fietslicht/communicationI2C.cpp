#include <Wire.h>
#include <Arduino.h>
#include "trafficLight.h"
#include "communicationI2C.h"
#include "waterSensor.h"

//This is the master on lan 11
#define SENDADDRESS (11)
#define RECEIVEADDRESS (8)
//------------------


void sendMessage(int msg)
{
  Wire.begin();
  Wire.beginTransmission(SENDADDRESS);
  Wire.write((msg & 0xFF00) >> 8);
  Wire.write (msg & 0xFF);
  Wire.endTransmission();
}

void receiveMessage()
{
  Wire.begin(RECEIVEADDRESS);
  Wire.onReceive(receiveEvent);
}


void receiveEvent(int message)
{
  while (2 <= Wire.available())
  {
    int receivedMsg = Wire.read() << 8;
    receivedMsg |= Wire.read();
    if (receivedMsg <= 127)
    {
      ReceivedState(receivedMsg);
    }
    else
    {
      TimerInterval(receivedMsg);
    }
  }
}

void switchStates(char input)
{  
  LastState(CurrentState());
  CurrentState(input);
}
