#include <stdio.h>
#include <Arduino.h>
#include "lights.h"

///////////////////////////////////////////////////////////
//Function interpretation of Light functions
///////////////////////////////////////////////////////////

Lights::Lights(uint8_t locationOnRegister, uint8_t* addressPort, uint8_t* registerLight) {
  port = addressPort;
  location = locationOnRegister;
  *registerLight |= (1 << location);
}

void Lights::Burn(unsigned long wait, unsigned long delay) {
  long burner = millis() + wait + delay;
  if (timeToBurn < burner) {
    timeToBurn = burner;
  }
  
  if (delay + millis() <= waitTill) {
    waitTill = delay + millis();
  }
}

void Lights::CheckState() {
  if (!(*port & (1 << location)) && millis() > waitTill) {
    waitTill = LONG_MAX;
  }
  if (millis() < timeToBurn && millis() >= waitTill) {
    *port |= (1 << location);
  } else {
    *port &= ~(1 << location);
  }
}

void Lights::Print() {
  char string[256] = "";
  sprintf(string, "Type: LED, Location on register: %i, Location: 0x%x, Status: ", location, (int)&port);
  if (*port & 1 << location) {
    sprintf(string + strlen(string), "On");
  } else {
    sprintf(string + strlen(string), "Off");
  }
  sprintf(string + strlen(string), ", TimeToBurn: %lu, Wait for: %lu", timeToBurn, waitTill);
  Serial.println(string);
}

///////////////////////////////////////////////////////////
//Functions for arrays of Lights
///////////////////////////////////////////////////////////

void PrintLights(Lights* lights, byte arraySize) {
  if (lights != NULL) {
    for (int i = 0; i < arraySize; i++) {
      lights[i].Print();
    }
  }
}

void CheckLightArray(const Lights* lights, byte arraySize) {
  if (lights != NULL) {
    for (int i = 0; i < arraySize; i++) {
      lights[i].CheckState();
    }
  }
}


int FollowSequence(const Lights* lights, byte arraySize, char directionOfLights, unsigned long timeToComplete) {
  if (lights != NULL) {
    switch (directionOfLights) {
      case 'l':
        for (int i = 0; i < arraySize; i++) {
          lights[arraySize - (i + 1)].Burn(timeToComplete, ((double)timeToComplete / arraySize) * i);
        }
        return 0;
      case 'r':
        for (int i = 0; i < arraySize; i++) {
          lights[i].Burn(timeToComplete, ((double)timeToComplete / arraySize) * i);
        }
        return 0;
      case 'u':
        for (int i = 0; i < arraySize; i++) {
          lights[i].Burn(timeToComplete * arraySize + 5000, 0);
        }
        return 0;
      default:
        Serial.println("Your direction is invalid! Please use either 'l' or 'r' as your direction");
        return -1;
    }
  } else {
    Serial.println("Your array is refering to NULL");
    return -1;
  }
}

