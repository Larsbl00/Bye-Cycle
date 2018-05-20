#include <stdint.h>
#include "protocol.h"
#include "button.h"

Button CreateButton(uint8_t location, volatile uint8_t* addressPin, volatile uint8_t* registerButton) {
  if (addressPin == NULL || registerButton == NULL) return {};
  Button button;
  button.pin = addressPin;
  button.location = location;
  *registerButton &= ~(1 << button.location);
  return button;
}


uint8_t ReadButton(Button* button) {
  if (button == NULL) return 0;
  uint8_t returnValue = 0;
  uint8_t readState = (*button->pin & (1 << button->location));
  if (readState != button->lastState) button->lastDebounceTime = millis();
  if (millis() - button->lastDebounceTime > 50) {
    if (readState != button->state) {
      button->state = readState;
      if (button->state) {
        button->lastTimeActive = millis();
        button->isSet = true;
        returnValue = 1;
      }
    }
  }
  button->lastState = readState;
  return (returnValue);
}


//Checks all buttons
void CheckButtonSet(Button* buttons, int arraySize, Lights* lights, int lightsSize) {
  if (arraySize != 2 || buttons == NULL) return;
  ReadButton(&buttons[0]);
  ReadButton(&buttons[1]);
  if (buttons[0].isSet && buttons[1].isSet) {
    char directionChar;
    long TimeToBurn = 50000 * DistanceBetweenLightPosts / DistanceBetweenButtonsInPair; //Values defined in the button.h
    long difference = buttons[0].lastTimeActive - buttons[1].lastTimeActive;
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
    buttons[0].isSet = false;
    buttons[1].isSet = false;
  }
}
