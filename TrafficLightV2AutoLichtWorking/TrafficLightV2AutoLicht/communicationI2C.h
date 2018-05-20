#ifndef _COMMUNICATIONI2C_H
#define _COMMUNICATIONI2C_H

void sendMessage(unsigned int timer);
void receiveMessage();
void receiveEvent(unsigned int message);
void switchStates(char input);

#endif
