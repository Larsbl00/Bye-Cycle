#ifndef _COMMUNICATIONI2C_H
#define _COMMUNICATIONI2C_H

void start_connection();
void master_send_request(char state);
void master_recieve_request(char *recievedByte);

#endif
