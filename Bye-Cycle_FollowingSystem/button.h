#ifndef BUTTON_H
#define BUTTON_H

//These distances are the distances in cm
#define DistanceBetweenButtonsInPair 1
#define DistanceBetweenLightPosts 4

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
    Button(uint8_t locationOnRegister, uint8_t* addressPin, uint8_t* registerButton);

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
    uint8_t Read();
    void Print();
};

#endif
