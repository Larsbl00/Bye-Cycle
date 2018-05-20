#include <Wire.h>
#include <Arduino.h>
#include "trafficLight.h"
#include "communicationI2C.h"


//This is the master on lan 11
#define SENDADDRESS (8)
#define RECEIVEADDRESS (11)
//------------------


void sendMessage(unsigned int timer)
{
  Wire.begin();
  Wire.beginTransmission(SENDADDRESS);
  Wire.write((timer & 0xFF00) >> 8);
  Wire.write (timer & 0xFF);
  Wire.endTransmission();
}

void receiveMessage()
{
  Wire.begin(RECEIVEADDRESS);
  Wire.onReceive(receiveEvent);
}


void receiveEvent(unsigned int message)
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
  Serial.println("Switching");
  Serial.print("After switch (n,o,in): (");
  Serial.print(LastState());
  Serial.print(CurrentState());
  Serial.print(input);
  Serial.print(")\n");
  Serial.println("_________________");
}
