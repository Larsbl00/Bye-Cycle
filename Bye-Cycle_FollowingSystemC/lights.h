#ifndef LIGHTS_H
#define LIGHTS_H
#include <Arduino.h>
#include <limits.h>


typedef struct{
    uint8_t location;
    volatile uint8_t* port = NULL;
    unsigned long timeToBurn;
    unsigned long waitTill = LONG_MAX;
} Lights;

//Functions

//Initializes the Light
//
//@param locationOnRegister: This is the location that it has on the register
//@param addressPort: This is the address of the Port on which the light is wired
//@param registerLight: This is register of the light
//
//@return: returns a new light
//
Lights CreateLights(uint8_t locationOnRegister, volatile uint8_t* addressPort, volatile uint8_t* registerLight);


//Sets the burn timer for the reffered light
//
//@param light: This is the light to change
//@param wait: This is how long the light will burn
//@param delay: This is the delay for the light to go on
//
void Burn(Lights* light, unsigned long wait, unsigned long delay);

//Checks whether a light should be on or Off
//
//@param light: This is that light that will be checked
//
void CheckState(Lights* light);

//Calls the CheckState() function of each light in the array. Every time this function is being called, it'll check if the light needs to be on or of
//
//@param lights: This is the array of lighst where it needs to check the state
//@param arraySize: This is the size of the array, so we don't go out of bounds
//
void CheckLightArray(Lights* lights, byte arraySize);

//Activates the lights in the order given by the direction
//
//@param lights : This is the array where it needs to turn the lights on
//@param arraySize : This is the size of the array so you don't go out of bounds
//@param direction : This is the char that indicates the direction of the lights
//@param timeToComplete : this is the time that needed for the user to complete the distance between one module of this program
//
//@return: Returns -1 if the opperation was unsuccessful else it'll return 0
//
int FollowSequence(Lights* lights, byte arraySize, char directionOfLights, unsigned long timeToComplete);

#endif
