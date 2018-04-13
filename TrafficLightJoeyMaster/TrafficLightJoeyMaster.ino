#include "trafficLight.h"
#include "communicationI2C.h"
#include "waterSensor.h"

char message = 'R';

unsigned long previousMillis = 1000;
long timer = 5000;
int sensorValue = 0;

void setup() {

  pinMode(ledGreen, OUTPUT);
  pinMode(ledOrange, OUTPUT);
  pinMode(ledRed, OUTPUT);

  Serial.begin(9600);
  Serial.println("----------------------------------------------------");
  Serial.println("Serial is online");

}

void loop()
{

  start_connection();

  waterSensor_measurement_mode(&sensorValue);
  waterSensor_change_interval(&sensorValue, &timer);

  master_send_request(message);

  master_recieve_request(&message);
  if (message == 'R')
  { //red
    modes(message);
    message = 'R';
    //Serial.println(message);
    //Serial.println("Red");
  }

  if (message == 'G')
  { //green
    modes(message);
    message = 'G';
    //Serial.println(message);
    //Serial.println("Green");
  }
}
