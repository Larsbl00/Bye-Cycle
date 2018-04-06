#include "trafficLight.h"
#include <Arduino.h>


//unsigned long previousMillis = 1000;
//long interval = 5000;
int ledState = LOW;

void modes(int stateChange) {

  switch (stateChange) {

    /*default:
      interval = 250;
      alarmMode(&ledState);
      break;*/

    case 51:    
      // lightState(&ledState, ledGreen);

        Serial.println("trafficLightGreen");       
        digitalWrite(ledGreen, HIGH);
        digitalWrite(ledOrange, LOW);
        digitalWrite(ledRed, LOW);
        delay(500);
      break;
    /*
        case 50:
          Serial.println("orange");
          lightState(&ledState, ledOrange);
          digitalWrite(ledGreen, LOW);
          digitalWrite(ledRed, LOW);
          break;
    */
    case 49:     
      //   lightState(&ledState, ledRed);
      Serial.println("trafficLightRed");    
      digitalWrite(ledRed, HIGH);
      digitalWrite(ledOrange, LOW);
      digitalWrite(ledGreen, LOW);
      delay(500);
      break;
  }
}

/*
void lightState(int* ledState , int ledPin)
{
  unsigned long currentMillis = millis();

  if (currentMillis - previousMillis >= interval)
  {
    previousMillis = currentMillis;

    if (*ledState == LOW)
    {
      *ledState = HIGH;
    }
    else
    {
      *ledState = LOW;
    }
    digitalWrite(ledPin, *ledState);
  }
}

void alarmMode(int* ledState)
{
  unsigned long currentMillis = millis();
  // Serial.println("alarmmode");
  if (currentMillis - previousMillis >= interval)
  {
    // Serial.println("looopo");
    previousMillis = currentMillis;

    if (*ledState == LOW)
    {
      *ledState = HIGH;

    }
    else
    {
      *ledState = LOW;

    }
    digitalWrite(ledRed, *ledState);
    digitalWrite(ledOrange, *ledState);
    digitalWrite(ledGreen, *ledState);
  }
}
*/



