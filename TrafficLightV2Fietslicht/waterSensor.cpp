#include "waterSensor.h"
#include <Wire.h>
#include <Arduino.h>

/*-------------------------------------------------------------*/
//Water sensor Hoya
//
//
/*-------------------------------------------------------------*/
long timerInterval;

long TimerInterval() {
  return timerInterval;
}

void TimerInterval(long value)
{
  timerInterval = value;
}

void waterSensor_measurement_mode()
{
  int sensorValue = analogRead(rainSensor);
  waterSensor_change_interval(sensorValue);
}

void waterSensor_change_interval(int sensorValue) {

  if (sensorValue > 100)
  {
    TimerInterval(rainTime);
  }
  else 
  {
    TimerInterval(standardTime);
  }
}



