#include <stdio.h>
#include <Arduino.h>
#include "lights.h"

void PrintLights(Lights* lights, byte arraySize) {
  if (lights != NULL){
    for (int i = 0; i < arraySize; i++) {
     lights[i].Print();
    }
  }
}

void CheckLightArray(const Lights* lights, byte arraySize) {
  if (lights != NULL){
    for (int i = 0; i < arraySize; i++) {
        lights[i].CheckState();
    }
  }
}

void FlipArray(Lights* from, Lights* to, byte arraySize) {
  if (from != NULL && to != NULL){
    for (int i = arraySize; i > 0; i--) {
        to[i-1] = from[arraySize -i];
    }
  }
}
