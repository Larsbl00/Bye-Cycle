#include <Arduino.h>
#include <stdint.h>
#include "ldr.h"

#define hysteresis 100
#define darkTreshold 450

bool isDark = false;
int samples[50];
const int samplesSize = sizeof(samples) / sizeof(samples[0]);
uint8_t samplesItterator = 0;


int ReturnAverage(byte analogInput) {
  if (samplesItterator > samplesSize) {
    samplesItterator = 0;
  }
  samples[samplesItterator] = analogRead(analogInput);
  samplesItterator++;
  long total;
  for (int i = 0; i < samplesSize; i++) total += samples[i];
  return (total / samplesSize);
}

bool IsDark(uint8_t pin) {
  int average = ReturnAverage(pin);
  if (average <= (darkTreshold - hysteresis)) {
    isDark = true;
  } else if (average >= (darkTreshold + hysteresis)){
    isDark = false;
  }
  return isDark;
}





