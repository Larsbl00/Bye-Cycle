#ifndef LDR_H
#define LDR_H

#include <stdint.h>

//Returns the average of the values of the given analogInput
//
//@param analogInput : This is the pin where the analog sensor is wired to
//
//@return: Returns the average analog value of the input
//
int ReturnAverage(byte analogInput);

//Returns if it is dark enough outside to trigger the system
//
//@param pin: This is the pin that it needs to read in order to see if it is dark
//
//@return: returns true if the average value of the read pin <= the treshold value, else it returns false
//
bool IsDark(uint8_t pin);

#endif
