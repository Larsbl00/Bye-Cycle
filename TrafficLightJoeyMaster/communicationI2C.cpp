#include <Wire.h>
#include <Arduino.h>
#include "communicationI2C.h"

#define ADDRESS (11)

void start_connection() {
  Wire.begin();
}

void master_send_request(char state) {
  Wire.beginTransmission(ADDRESS);
  Wire.write(state);
  Wire.endTransmission();
}
/*
  void master_send_request_ping(char* sendMessage, int messageLength) {
  Wire.beginTransmission(ADDRESS);
  Wire.write(sendMessage, messageLength);
  Wire.endTransmission();
  }
*/

void master_recieve_request(char *recievedByte )
{

  Wire.requestFrom(ADDRESS, 1);

  if (Wire.available())
  {
    *recievedByte = Wire.read();
    // Serial.println(*recievedByte);
  }
}



void SendIformation(String* device, String* command, int* value) {
    Serial.print("%");
    Serial.print(*device);
    Serial.print(":");
    Serial.print(*command);
    Serial.print("-");
    Serial.print(*value, 1);
    Serial.println("#");
}



