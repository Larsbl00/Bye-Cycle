#ifndef LIGHTS_H
#define LIGHTS_H
#include <Arduino.h>


class Lights {
  private:
    uint8_t location;
    uint8_t* port = NULL;
    unsigned long timeToBurn;


  public:
    //Constructor
    Lights(uint8_t locationOnRegister, uint8_t* addressPort, uint8_t* registerLight) {
      port = addressPort;
      location = locationOnRegister;
      *registerLight |= (1<<location);
    }

    //Functions
    void Burn(unsigned long wait) {
      timeToBurn = millis() + wait;
    }

    void CheckState() {
      if (millis() < timeToBurn) {
        *port |= (1<<location);
      } else {
        *port &= ~(1<<location);
      }
    }

    void Print() {
      Serial.print("Location on register: ");
      Serial.print(location);
      Serial.print(", ");
      Serial.print("Port: 0x");
      Serial.print(*port, HEX);
      Serial.print(", ");
      Serial.print("Time to burn: ");
      Serial.print(timeToBurn);
      Serial.println("");
    }
};

//Methods

//Flips an array of Lights
//
//@param from: This is the array where it copies all entries from
//@param to: This is the array where it puts the reversed order of from
//@param arraySize: This defines the array size, so you don't go out of bounds
//
void FlipArray(Lights* from, Lights* to, byte arraySize);

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
