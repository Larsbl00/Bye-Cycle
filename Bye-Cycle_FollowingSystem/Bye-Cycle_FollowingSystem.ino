#include <Arduino.h>
#include <string.h>
#include "ldr.h"
#include "lights.h"
#include "button.h"

#define ldr A0

Lights lights[] = {Lights (2, &PORTD, &DDRD), Lights(4, &PORTD, &DDRD), Lights(7, &PORTD, &DDRD), Lights(0, &PORTB, &DDRB)};

Button buttons1[] = {Button(2, &PINB, &DDRB), Button(3, &PINB, &DDRB)};
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

void CheckButtonSet(Button* buttons, int arraySize) {
  if (arraySize != 2) return;
  buttons[0].Read();
  buttons[1].Read();
  if (buttons[0].IsSet() && buttons[1].IsSet()) {
    char directionChar;
    long TimeToBurn = 50000 * DistanceBetweenLightPosts / DistanceBetweenButtonsInPair; //Values defined in the button.h
    long difference = buttons[0].LastTimeActive() - buttons[1].LastTimeActive();
    if (difference > 0) {
      //Button1 was pressed later than Button2 -> Cyclist goes left
      directionChar = 'l';
    } else if (difference < 0) {
      //Button2 was pressed later than Button1 -> Cyclist goed right
      directionChar = 'r';
    } else {
      //There was no difference -> No direction detected, activates error mode
      directionChar = 'u';
    }
    TimeToBurn = (abs(difference) * DistanceBetweenLightPosts / DistanceBetweenButtonsInPair);
    SendProtocol('D', "direction", directionChar);
    FollowSequence(lights, lightsSize, directionChar, TimeToBurn);
    buttons[0].IsSet(false);
    buttons[1].IsSet(false);
  }
}

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
    Serial.println(varToChange);
    Serial.println(value);
    if (varToChange == "followOff") {
      systemIsOn = !(bool)value;
    }
  }
}

void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  PrintLights(lights, lightsSize);
}

void loop() {
  CheckLightArray(lights, lightsSize);

  if (lastTimeSystemOn != systemIsOn) {
    SendProtocol('D', "isActive", systemIsOn);
  }

  digitalWrite(13, systemIsOn);

  if (systemIsOn && IsDark(ldr)) {
    CheckButtonSet(buttons1, 2);
    CheckButtonSet(buttons2, 2);
  }

  lastTimeSystemOn = systemIsOn;
}
