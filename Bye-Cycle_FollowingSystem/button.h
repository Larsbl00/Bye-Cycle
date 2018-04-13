#ifndef BUTTON_H
#define BUTTON_H

//These distances are the distance in cm
#define DistanceBetweenButtonsInPair 1
#define DistanceBetweenLightPosts 8

#include <stdint.h>
#include <stdio.h>
#include "lights.h"


class Button {
  private:
    bool isSet;
    uint8_t location;
    uint8_t state;
    uint8_t lastState = 0;
    uint8_t* pin = NULL;
    unsigned long lastDebounceTime = 0;
    unsigned long lastTimeActive;


  public:
    //Constructor
    Button(uint8_t locationOnRegister, uint8_t* addressPin, uint8_t* registerButton) {
      pin = addressPin;
      location = locationOnRegister;
      *registerButton &= ~(1 << location);
    }

    //Properties
    long LastTimeActive() {
      return lastTimeActive;
    }

    bool IsSet() {
      return isSet;
    }

    void IsSet(bool value) {
      isSet = value;
    }

    //Functions
    uint8_t Read() {
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

    void Print() {
      Serial.print("Type: Button, ");
      Serial.print("Location on register: ");
      Serial.print(location);
      Serial.print(", ");
      Serial.print("Location: 0x");
      Serial.print((int)&pin, HEX);
      Serial.print(", ");
      Serial.print("State: ");
      if (*pin & (1 << location)) {
        Serial.print("On\n");
      } else  {
        Serial.print("Off\n");
      }
    }
};

//Functions




#endif