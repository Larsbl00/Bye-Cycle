#include <Wire.h>
#include <Arduino.h>
#include "trafficLight.h"
#include "communicationI2C.h"


//This is the master on lan 11
#define SENDADDRESS (8)
#define RECIEVEADDRESS (11)
//------------------


void sendMessage(char* state)
{
  Wire.begin();
  Wire.beginTransmission(SENDADDRESS);
  Wire.write(state);
  Wire.endTransmission();
}

void recieveMessage()
{
  Wire.begin(RECIEVEADDRESS);
  Wire.onReceive(receiveEvent);
}


void receiveEvent(char message)
{
  if (LastState() != CurrentState())
  {
    LastState(CurrentState());
  }
  
  if (Wire.available())
  {
    message = Wire.read();
    CurrentState(message);
    Serial.print("Currenstate : ");
    Serial.println(CurrentState());
    Serial.print("LastState : ");
    Serial.println(LastState());
  }
}
/*
  if ( msg == 'r' )
  {
    modes('g');
  }

  if ( msg == 'g'|| msg == 'o')
  {
    modes('r');
  }
*/


