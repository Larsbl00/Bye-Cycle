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
    uint8_t lastState;
    volatile uint8_t* pin;
    unsigned long lastDebounceTime;
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

//Checkecks in which order the buttons were pressed, and activates the lights according to it's calculations
//
//@param buttons: The array of buttons to check through
//@param arraySize: This is the size of the array so we don't go out of bounds
//@param lights: This is the array of lights we need to turn on when the buttons were pressed
//@param: lightsSize: This is the size of the array of lights, so we don't go out of bounds
//
void CheckButtonSet(Button* buttons, int arraySize, Lights* lights, int lightsSize);

#endif
