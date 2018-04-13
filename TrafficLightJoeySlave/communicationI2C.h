#ifndef _COMMUNICATIONI2C_H
#define _COMMUNICATIONI2C_H

void start_connection();

void slave_recieve_request();
void recieveEvent(char recievedByte);

//void slave_recieve_request_ping();
//void recieveEventPing(int recievedByte);

void slave_send_request(char requestOtherMode);
void requestEventRed();
void requestEventOrange();
void requestEventGreen();

#endif
