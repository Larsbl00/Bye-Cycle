#include "trafficLight.h"
#include "communicationI2C.h"

unsigned long previousMillis = 1000;

void setup() {

  pinMode(ledGreen, OUTPUT);
  pinMode(ledOrange, OUTPUT);
  pinMode(ledRed, OUTPUT);

  Serial.begin(9600);
  Serial.println("----------------------------------------------------");
  Serial.println("Serial is online");
  Serial.println("----------------------------------------------------");
  CurrentState('r');
  //modes(CurrentState());
}

void loop()
{
  unsigned long currentMillis = millis();
  sendMessage(CurrentState());
  delay(2);
  //sendMessage(420);
  receiveMessage();
  delay(2);
  if (millis() - previousMillis >= TimerInterval())
  {
    previousMillis = millis();
    Serial.println("_________________");
    Serial.println("New data received");
    Serial.println(ReceivedState());
    Serial.print(CurrentState());
    Serial.print(" (was: ");
    Serial.print(LastState());
    Serial.print(")\n");
    if (ReceivedState() == 'g' || ReceivedState() == 'o')
    {
      switchStates('r');
      modes(CurrentState());
    }

    else if (ReceivedState() == 'r')
    {
      if (CurrentState() == 'r' || LastState() == NULL)
      {
        switchStates('g');
        modes(CurrentState());
      }
      else if (CurrentState() == 'g' )
      {
        switchStates('o');
        modes(CurrentState());
      }
      else if (CurrentState() == 'o')
      {
        switchStates('r');
        modes(CurrentState());
      }
    }
  }
}
