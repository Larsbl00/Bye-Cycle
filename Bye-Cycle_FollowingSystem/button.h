#ifndef BUTTON_H
#define BUTTON_H

#include <stdint.h>
#include <stdio.h>

class Button {
  private:
    uint8_t location;
    uint8_t* port = NULL;


  public:
    //Constructor
    Button(uint8_t locationOnRegister, uint8_t* addressPort, uint8_t* registerLight) {
      port = addressPort;
      location = locationOnRegister;
      *registerLight &= ~(1 << location);
    }

    //Functions
    uint8_t Read() {
      return (*port & (1<<location));
    }

    void Print() {
      Serial.print("Location on register: ");
      Serial.print(location);
      Serial.print(", ");
      Serial.print("Location: 0x");
      Serial.print((int)&port, HEX);
      Serial.print(", ");
      Serial.print("State: ");
      Serial.print(this->Read());
      Serial.println("");
    }
};

#endif
