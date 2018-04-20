#include <Arduino.h>
#include <stdint.h>
#include "ldr.h"

#define hysteresis 45
#define darkTreshold 430

int samples[100];
const int samplesSize = sizeof(samples) / sizeof(samples[0]);
uint8_t samplesItterator = 0;


int returnAverage(byte analogInput) {
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
  bool isDark = false;
  int average = returnAverage(pin);
  if (average <= (darkTreshold - hysteresis) && isDark == false) {
    isDark = true;
  } /*else if (average > (darkTreshold + hysteresis) && isDark) {
    isDark = false;
  }*/
  return isDark;
}





