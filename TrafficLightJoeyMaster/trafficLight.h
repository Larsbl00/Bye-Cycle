#ifndef _TRAFFICLIGHT_H
#define _TRAFFICLIGHT_H

#define ledGreen 5
#define ledOrange 6
#define ledRed 7


void modes(char stateChange);
void alarmMode(int* ledState);
void lightState(int* ledState, int ledPin);


#endif
