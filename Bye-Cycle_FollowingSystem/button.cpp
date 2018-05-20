#include <stdint.h>
#include "button.h"
#include "protocol.h"

///////////////////////////////////////////////////////////
//Function interpretation of Button functions
///////////////////////////////////////////////////////////
Button::Button(uint8_t locationOnRegister, uint8_t* addressPin, uint8_t* registerButton) {
  pin = addressPin;
  location = locationOnRegister;
  *registerButton &= ~(1 << location);
}

uint8_t Button::Read() {
  uint8_t returnValue = 0;
  uint8_t readState = (*pin & (1 << location));
  if (readState != lastState) lastDebounceTime = millis();
  if (millis() - lastDebounceTime > 50) {
    if (readState != state) {
      state = readState;
      if (state) {
        lastTimeActive = millis();
        isSet = true;
        returnValue = 1;
      }
    }
  }
  lastState = readState;
  return (returnValue);
}

void Button::Print() {
  char string[128] = "";
  sprintf(string, "Type: Button, Location on register: %i, Location: 0x%x, State: ", location, (int)&pin);
  if (*pin & (1 << location)) {
    strcat(string, "On");
  } else  {
    strcat(string, "Off");
  }
  Serial.println(string);
}

///////////////////////////////////////////////////////////
//Other functions for the buttons
///////////////////////////////////////////////////////////

//Checks all buttons
void CheckButtonSet(Button* buttons, int arraySize, Lights* lights, int lightsSize) {
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
