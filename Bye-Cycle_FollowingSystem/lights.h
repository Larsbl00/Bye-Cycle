#ifndef LIGHTS_H
#define LIGHTS_H
#include <Arduino.h>


class Lights {
  private:
    uint8_t location;
    volatile uint8_t* port = NULL;
    unsigned long timeToBurn;
    unsigned long waitTill;


  public:
    //Constructor
    Lights(uint8_t locationOnRegister, volatile uint8_t* addressPort, volatile uint8_t* registerLight) {
      port = addressPort;
      location = locationOnRegister;
      *registerLight |= (1 << location);
    }

    //Functions
    void Burn(unsigned long wait) {
      timeToBurn = millis() + wait;
      waitTill = 0;
    }

    void Burn(unsigned long wait, unsigned long delay) {
      timeToBurn = millis() + wait + delay;
      waitTill = millis() + delay;
    }

    void CheckState() {
      if (millis() < timeToBurn && millis() >= waitTill) {
        *port |= (1 << location);
      } else {
        *port &= ~(1 << location);
      }
    }

    void Print() {
      Serial.print("Location on register: ");
      Serial.print(location);
      Serial.print(", ");
      Serial.print("Location: 0x");
      Serial.print((int)&port, HEX);
      Serial.print(", ");
      Serial.print("Time to burn: ");
      Serial.print(timeToBurn);
      Serial.print(", ");
      long remaining = timeToBurn - millis();
      if (remaining > 0) {
        Serial.print("Time remaining: ");
        Serial.print(remaining);
      } else {
        Serial.print("Time remaining: ");
        Serial.print(0);
      }
      Serial.print(", ");
      Serial.print("Wait for: ");
      Serial.print(waitTill);
      Serial.println("");
    }
};

//Methods

//Uses the Print methode on all lights in the array
//
//@param lights: This is the array where it calls the print methode off
//@param arraySize: This defines the array size, so you don't go out of bounds
//
void PrintLights(Lights* lights, byte arraySize);

//Calls the CheckState() function of each light in the array. Every time this function is being called, it'll check if the light needs to be on or of
//
//@param lights: This is the array of lighst where it needs to check the state
//@param arraySize: This is the size of the array, so we don't go out of bounds
//
void CheckLightArray(const Lights* lights, byte arraySize);

#endif
