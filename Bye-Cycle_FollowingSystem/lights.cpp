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

int FollowSequence(const Lights* lights, byte arraySize, char direction, unsigned long timeToComplete) {
  if (lights != NULL) {
    byte itterator = 0;
    switch (direction) {
    case 'l':
      itterator = arraySize;
      
        break;
      case 'r':

        break;
      default:
        Serial.println("Your direction is invalid! Please use either 'l' or 'r'");
          break;
      }
    } else return -1;
  }

