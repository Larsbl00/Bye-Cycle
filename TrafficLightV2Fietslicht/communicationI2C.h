#ifndef _COMMUNICATIONI2C_H
#define _COMMUNICATIONI2C_H

void sendMessage(int msg);

void receiveMessage();
void receiveEvent(int message);
void switchStates(char input);
#endif
