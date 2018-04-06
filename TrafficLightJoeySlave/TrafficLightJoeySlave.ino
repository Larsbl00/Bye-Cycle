#include "trafficLight.h"
#include "communicationI2C.h"

void setup() {

  pinMode(ledGreen, OUTPUT);
  pinMode(ledOrange, OUTPUT);
  pinMode(ledRed, OUTPUT);

  Serial.begin(9600);
  Serial.println("----------------------------------------------------");
  Serial.println("Serial is online");

  start_connection();
  Serial.println("----------------------------------------------------");
  Serial.println("I2C started");

}

void loop() 
{
  
  slave_recieve_request();
}
