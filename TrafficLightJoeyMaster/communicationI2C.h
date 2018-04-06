#ifndef _COMMUNICATIONI2C_H
#define _COMMUNICATIONI2C_H

void start_connection();
void master_send_request(int state);
//void master_send_request_ping(char* sendMessage, int messageLength) ;
void master_recieve_request(int *recievedByte);

#endif
