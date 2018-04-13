#include <Arduino.h>
#include "ldr.h"

int samples[10];
const int samplesSize = sizeof(samples) / sizeof(samples[0]);
byte samplesItterator = 0;


int returnAverage(byte analogInput) {
  if (samplesItterator < samplesSize) {
    samples[samplesItterator] = analogRead(analogInput);
  } else {
    samplesItterator = 0;
    samples[samplesItterator] = analogRead(analogInput);
  }

  long total;
  for (int i = 0; i < samplesSize; i++) total += samples[i];
  return (int)(total / samplesSize);
}


