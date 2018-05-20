#ifndef BUTTON_H
#define BUTTON_H

#include <stdint.h>
#include <stdio.h>
#include "lights.h"

//These distances are the distances in cm
#define DistanceBetweenButtonsInPair 1
#define DistanceBetweenLightPosts 4


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

    //Constructor
    Button(uint8_t locationOnRegister, uint8_t* addressPin, uint8_t* registerButton);

    //Functions
    uint8_t Read();
    void Print();
};

//Checks the state of all buttons, and sends the protocols when needed
//
//@param buttons: This is the array of buttons we're checking
//@param arraySize: This is the Size of the array so we don't go out of bounds
//@param lights: This is the array of lights that needs to be triggered
//@param lightsSzie: This is the size of the lights array, so we don't go out of bounds
//
void CheckButtonSet(Button* buttons, int arraySize, Lights* lights, int lightsSize);

#endif
