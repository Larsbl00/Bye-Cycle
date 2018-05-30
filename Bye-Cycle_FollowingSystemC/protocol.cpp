#include <Arduino.h>
#include "protocol.h" 

void SendProtocol(char person, char* var, int value){
  if (var == NULL) return;
  char messageToSend[64] = "";
  sprintf(messageToSend, "%c%c:%s-%i#", '%', person, var, value);
  Serial.println(messageToSend);
}