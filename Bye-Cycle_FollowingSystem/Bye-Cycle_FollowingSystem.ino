#include <Arduino.h>
#include <string.h>
#include "ldr.h"
#include "lights.h"
#include "button.h"

#define ldr A0

//Located on pins 2, 4, 7, 8
Lights lights[] = {Lights (2, &PORTD, &DDRD), Lights(4, &PORTD, &DDRD), Lights(7, &PORTD, &DDRD), Lights(0, &PORTB, &DDRB)};

//Located on pins 10, 11 
Button buttons1[] = {Button(2, &PINB, &DDRB), Button(3, &PINB, &DDRB)};

//Located on pins 5, 6
Button buttons2[] = {Button(5, &PIND, &DDRD), Button(6, &PIND, &DDRD)};

bool systemIsOn = true;
bool lastTimeSystemOn;
String serialInput;
const uint8_t lightsSize =  sizeof(lights) / sizeof(Lights);

void SendProtocol(char person, char* var, int value) {
  if (var == NULL) return;
  char messageToSend[128] = "";
  sprintf(messageToSend, "%c%c:%s-%i#", '%', person, var, value);
  Serial.println(messageToSend);
}

//Checks all buttons
void CheckButtonSet(Button* buttons, int arraySize) {
  if (arraySize != 2 || buttons == NULL) return;
  buttons[0].Read();
  buttons[1].Read();
  if (buttons[0].IsSet() && buttons[1].IsSet()) {
    char directionChar;
    long TimeToBurn = 50000 * DistanceBetweenLightPosts / DistanceBetweenButtonsInPair; //Values defined in the button.h
    long difference = buttons[0].LastTimeActive() - buttons[1].LastTimeActive();
    if (difference > 0) {
      //Button1 was pressed later than Button2 -> Cyclist moves left in the array
      directionChar = 'l';
    } else if (difference < 0) {
      //Button2 was pressed later than Button1 -> Cyclist moves right in the array
      directionChar = 'r';
    } else {
      //There was no difference -> No direction detected, activates error mode
      directionChar = 'u';
    }
    TimeToBurn = (abs(difference) * DistanceBetweenLightPosts / DistanceBetweenButtonsInPair);
    SendProtocol('D', "timeActive", TimeToBurn);
    SendProtocol('D', "direction", directionChar);
    FollowSequence(lights, lightsSize, directionChar, TimeToBurn);
    buttons[0].IsSet(false);
    buttons[1].IsSet(false);
  }
}

//This event is triggered when something was recieved in the serialport
void serialEvent() {
  serialInput = "";
  while (Serial.available()) {
    serialInput += (char)Serial.read();
    delay(2);
  }
  //Sample protocol: %<DestinationLetter>:<Command>-<Value>#
  if (serialInput != "" && serialInput.charAt(0) == '%' && serialInput.charAt(1) == 'F' && serialInput.indexOf('#') != -1) {
    String varToChange = serialInput.substring(3, serialInput.indexOf('-'));
    uint8_t value = serialInput.substring(serialInput.indexOf('-') + 1, serialInput.indexOf('#')).toInt();
    //Sample turn-on protocol: %F:followOff-0# 
    if (varToChange == "followOff") {
      systemIsOn = !(bool)value;
    }
  }
}

void setup() {
  Serial.begin(38400);
  pinMode(13, OUTPUT);

  //Prints all items, this is for debugging purposes
  PrintLights(lights, lightsSize);
  buttons1[0].Print();
  buttons1[1].Print();
  buttons2[0].Print();
  buttons2[1].Print();
}

void loop() {
  //Calls the check funtion on lights, to determine if they should be on
  CheckLightArray(lights, lightsSize);

  if (IsDark(ldr)) {
    if (systemIsOn) {
      CheckButtonSet(buttons1, 2);
      CheckButtonSet(buttons2, 2);
    } else {
      for (int i = 0; i < lightsSize; i++) {
        lights[i].Burn(1, 0);
      }
    }
  }
  lastTimeSystemOn = systemIsOn;
}
