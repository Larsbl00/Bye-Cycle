#ifndef PROTCOL_H
#define PROTCOL_H

//Sends a message via the serial line, according to our format
//
//@param person: The letter that indicates to whom we're sending a message (e.g. F: Followingsystem)
//@param var: This is the variable that you want to send
//@param value: This is the value that the var has
//
void SendProtocol(char person, char* var, int value);

#endif 