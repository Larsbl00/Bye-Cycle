#ifndef LDR_H
#define LDR_H


#define hysteresis 20

//Returns the average of the values of the given analogInput
//
//@param analogInput : This is the pin where the analog sensor is wired to
//
long returnAverage(byte analogInput);

#endif
