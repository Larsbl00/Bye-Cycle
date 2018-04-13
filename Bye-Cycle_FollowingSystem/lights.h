#ifndef LIGHTS_H
#define LIGHTS_H
#include <Arduino.h>


class Lights {
  private:
    uint8_t location;
    uint8_t* port = NULL;
    unsigned long timeToBurn;
    unsigned long waitTill = -1;


  public:
    //Constructor
    Lights(uint8_t locationOnRegister, uint8_t* addressPort, uint8_t* registerLight) {
      port = addressPort;
      location = locationOnRegister;
      *registerLight |= (1 << location);
    }

    //Functions
    void Burn(unsigned long wait, unsigned long delay) {
      timeToBurn = millis() + wait + delay;
      if (delay + millis() <= waitTill) {
        waitTill = delay + millis();
      }
    }

    void CheckState() {
      if (!(*port & (1 << location)) && millis() > waitTill) {
        waitTill = -1;
      }
      if (millis() < timeToBurn && millis() >= waitTill) {
        *port |= (1 << location);
      } else {
        *port &= ~(1 << location);
      }
    }

    void Print() {
      Serial.print("Type: LED, ");
      Serial.print("Location on register: ");
      Serial.print(location);
      Serial.print(", ");
      Serial.print("Location: 0x");
      Serial.print((int)&port, HEX);
      Serial.print(", ");
      Serial.print("Status: ");
      if (*port & 1 << location) {
        Serial.print("On");
      } else {
        Serial.print("Off");
      }
      Serial.print(", ");
      Serial.print("Time to burn: ");
      Serial.print(timeToBurn);
      Serial.print(", ");
      Serial.print(", ");
      Serial.print("Wait for: ");
      Serial.print(waitTill);
      Serial.println("");
    }
};

//Functions

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

//Activates the lights in the order given by the direction
//
//@param lights : This is the array where it needs to turn the lights on
//@param arraySize : This is the size of the array so you don't go out of bounds
//@param direction : This is the char that indicates the direction of the lights
//@param timeToComplete : this is the time that needed for the user to complete the distance between one module of this program
//
int FollowSequence(const Lights* lights, byte arraySize, char directionOfLights, unsigned long timeToComplete);

#endif
