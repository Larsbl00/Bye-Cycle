#include <stdint.h>
#include "button.h"

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
