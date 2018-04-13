#include "trafficLight.h"
#include "communicationI2C.h"
#include "waterSensor.h"
int message = 49;
unsigned long previousMillis = 1000;
long interval = 5000;
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


  //char messagePing[] = "ping";

  //master_send_request_ping(messagePing, 4);
  // master_recieve_request(message, messageLength);

  start_connection();
  Serial.println("----------------------------------------------------");
  Serial.println("I2C started");

  Serial.print("First send ");
  Serial.println(message);
  master_send_request(message);

  master_recieve_request(&message);

  if (message == 49)
  { //red
    modes(49);
    message = 49;
    Serial.print("We zitten nu in state 49 :");
    Serial.println(message);
    Serial.println("Red");
  }

  /*
    if (message == 50)
    { //orange
    modes(50);
    message = 50;
    Serial.println("orange");
    }
  */
  if (message == 51)
  { //green
    modes(51);
    message = 51;
    Serial.print("We zitten nu in state 51 :");
    Serial.println(message);
    Serial.println("Green");
  }

  /*  else
    {
      modes(0);
      master_send_request(0);
    }*/

}
