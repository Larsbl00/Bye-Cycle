#ifndef _TRAFFICLIGHT_H
#define _TRAFFICLIGHT_H

#define ledGreen 5
#define ledOrange 6
#define ledRed 7

char CurrentState();
char LastState();
long TimerInterval();

void CurrentState(char value);
void LastState(char value);
void TimerInterval(long value);

void modes(char state);


#endif
