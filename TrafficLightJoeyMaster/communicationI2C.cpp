#include <Wire.h>
#include <Arduino.h>
#include "communicationI2C.h"

/*-------------------------------------------------------------*/
// COM17
// This library connects the Arduino to a device with I2C
// protocol. It is also a master.
//
//
#define ADDRESS (11)

/*-------------------------------------------------------------*/
void start_connection() {
  Wire.begin();
}

void master_send_request(int state) {
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

void master_recieve_request(int *recievedByte )
{

  Wire.requestFrom(ADDRESS, 1);

  if (Wire.available())
  {
    *recievedByte = Wire.read();
    Serial.println(*recievedByte);
  }
}


/*
  void SendIformation(float* Longitude, float* Latitude, int* forwardMessage, int* distance) {
  if (*Longitude != 0 || *Latitude != 0) {
    Serial.print("%B");
    Serial.print(*Latitude, 6);
    Serial.print("!");
    Serial.print(*Longitude, 6);
    Serial.print("!");
    Serial.print(*forwardMessage, 1);
    Serial.print("!");
    Serial.print(*distance);
    Serial.println("#");
  }
  }

*/

