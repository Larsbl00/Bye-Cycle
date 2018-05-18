#include "trafficLight.h"
#include "communicationI2C.h"
#include "waterSensor.h"
unsigned long previousMillis = 1000;

void setup() {

  pinMode(ledGreen, OUTPUT);
  pinMode(ledOrange, OUTPUT);
  pinMode(ledRed, OUTPUT);

  Serial.begin(9600);
  Serial.println("----------------------------------------------------");
  Serial.println("Serial is online");
  Serial.println("----------------------------------------------------");
  CurrentState('g');
  TimerInterval(2000);
}

void loop()
{
  unsigned long currentMillis = millis();

  receiveMessage();
  delay(2);
  sendMessage(CurrentState());
  delay(2);
  
  waterSensor_measurement_mode();
  unsigned int timerInterval = standardTime;
  
  if (currentMillis - previousMillis >= TimerInterval())
  {
    previousMillis = currentMillis;

    if (ReceivedState() == 'g' || ReceivedState() == 'o' )
    {
      switchStates('r');
      modes(CurrentState());
    }

    else if (ReceivedState() == 'r')
    {
      if (CurrentState() == 'o' || CurrentState() == NULL)
      {
        switchStates('r');
        modes(CurrentState());
      }
      else if (CurrentState() == 'r' )
      {
        switchStates('g');
        modes(CurrentState());
        timerInterval = TimerInterval();
        sendMessage(TimerInterval());
        delay(2);
      }
      else if (CurrentState() == 'g' )
      {
        switchStates('o');
        modes(CurrentState());
      } 
    }
    sendMessage(timerInterval);
    delay(2);
  }
}




