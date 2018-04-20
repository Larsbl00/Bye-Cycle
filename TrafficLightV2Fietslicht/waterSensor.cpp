#include "waterSensor.h"
#include <Wire.h>
#include <Arduino.h>

#define rainSensor A0 
/*-------------------------------------------------------------*/
//Water sensor Hoya
//
//
/*-------------------------------------------------------------*/

int waterSensor_measurement_mode(int *sensorValue)
{
  
  *sensorValue = analogRead(rainSensor);
  Serial.println(*sensorValue);
}

int waterSensor_change_interval(int *sensorValue, long *timer){

  if(*sensorValue< 100)
  {   
    *timer = 100;    
  }
  else{ 
     timer = 5000;    
  }
}

