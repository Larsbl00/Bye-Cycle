#include <stdio.h>
#include <Arduino.h>
#include "lights.h"

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

