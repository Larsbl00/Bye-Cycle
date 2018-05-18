#ifndef BUTTON_H
#define BUTTON_H

#include <stdint.h>
#include <stdio.h>
#include "lights.h"

//These distances are the distances in cm
#define DistanceBetweenButtonsInPair 1
#define DistanceBetweenLightPosts 4


typedef struct{
    bool isSet;
    uint8_t location;
    uint8_t state;
    uint8_t lastState = 0;
    volatile uint8_t* pin = NULL;
    unsigned long lastDebounceTime = 0;
    unsigned long lastTimeActive;
} Button;

//Initializes the button
//
//@param location: This is the location on the register
//@param addressPin: This is the address of the pin
//@param registerButton: This is the register on which the pin is located
//
//@return: returns a new button
//
Button CreateButton(uint8_t location, volatile uint8_t* addressPin, volatile uint8_t* registerButton);

//Reads the button with debounce 
//
//@param button: This is the button to which it's reffering
//
//@return: Returns 0 if the button is a NULL pointer or when the button is not pressed, otherwise it'll return 
//
uint8_t ReadButton(Button* button);

void CheckButtonSet(Button* buttons, int arraySize, Lights* lights, int lightsSize);

#endif
