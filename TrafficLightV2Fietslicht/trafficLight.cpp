#include "trafficLight.h"
#include <Arduino.h>

char currentState;
char lastState;
long timerInterval;
//----------------------------------------------
char CurrentState() {
  return currentState;
}
char LastState() {
  return lastState;
}
long TimerInterval(){
  return timerInterval;
}
//----------------------------------------------
void CurrentState(char value)
{
  currentState = value;
}
void LastState(char value)
{
  lastState = value;
}
void TimerInterval(long value)
{
  timerInterval = value;
}
//----------------------------------------------



void modes(char state) {

  switch (state) {

    case 'r':
      //  Serial.println("red");
      digitalWrite(ledRed, HIGH);
      digitalWrite(ledOrange, LOW );
      digitalWrite(ledGreen, LOW);
      break;

    case 'o':
      // Serial.println("orange");
      digitalWrite(ledRed, LOW);
      digitalWrite(ledOrange, HIGH);
      digitalWrite(ledGreen, LOW);
      break;

    case 'g':
      // Serial.println("green");
      digitalWrite(ledRed, LOW);
      digitalWrite(ledOrange, LOW);
      digitalWrite(ledGreen, HIGH);
      break;

  }
}




