#include <stdio.h>
#include <Arduino.h>
#include "lights.h"

Lights CreateLights(uint8_t locationOnRegister, volatile uint8_t* addressPort, volatile uint8_t* registerLight){
  Lights light;
  light.port = NULL;
  if (addressPort == NULL || registerLight == NULL) return light;
  light.port = addressPort;
  light.location = locationOnRegister;
  *registerLight |= (1 << light.location);
  return light;
}

void Burn(Lights* light, unsigned long wait, unsigned long delay){
  if (light == NULL) return;
  long burner = millis() + wait + delay;
  if (light->timeToBurn < burner) {
    light->timeToBurn = burner;
  }
  
  if (delay + millis() <= light-> waitTill) {
    light->waitTill = delay + millis();
  }
}

void CheckState(Lights* light){
  if (light == NULL) return;
  if (!(*light->port & (1 << light->location)) && millis() > light->waitTill) {
    light->waitTill = LONG_MAX;
  }
  if (millis() < light->timeToBurn && millis() >= light->waitTill) {
    *light->port |= (1 << light->location);
  } else {
    *light->port &= ~(1 << light->location);
  } 
}


///////////////////////////////////////////////////////////
//Functions for arrays of Lights
///////////////////////////////////////////////////////////

void CheckLightArray(Lights* lights, byte arraySize) {
  if (lights != NULL) {
    for (int i = 0; i < arraySize; i++) {
      CheckState(&lights[i]);
    }
  }
}


int FollowSequence(Lights* lights, byte arraySize, char directionOfLights, unsigned long timeToComplete) {
  if (lights == NULL){
    Serial.println("Your array is refering to NULL");
    return -1;
  }

  switch (directionOfLights) {
    case 'l':
      for (int i = 0; i < arraySize; i++) {
        Burn(&lights[arraySize - (i + 1)], timeToComplete, ((double)timeToComplete / arraySize) * i);
      }
      return 0;
    case 'r':
      for (int i = 0; i < arraySize; i++) {
        Burn(&lights[i], timeToComplete, ((double)timeToComplete / arraySize) * i);
      }
      return 0;
    case 'u':
      for (int i = 0; i < arraySize; i++) {
        Burn(&lights[i], timeToComplete * arraySize + 5000, 0);
      }
      return 0;
    default:
      Serial.println("Your direction is invalid! Please use either 'l' or 'r' as your direction");
      return -1;
  }
}

