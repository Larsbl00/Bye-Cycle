#include <Arduino.h>
#include "ldr.h"
#include "lights.h"
#include "button.h"

Lights lights[] = {Lights (2, &PORTD, &DDRD), Lights(4, &PORTD, &DDRD), Lights(7, &PORTD, &DDRD), Lights(0, &PORTB, &DDRB)};

Button button1 = Button(2, &PINB, &DDRB);
Button button2 = Button(3, &PINB, &DDRB);

const uint8_t lightsSize =  sizeof(lights) / sizeof(Lights);
bool timerIsSet = false;

void setup() {
  Serial.begin(9600);
  PrintLights(lights, lightsSize);
  button1.Print();
  button2.Print();
}

void loop() {
  CheckLightArray(lights, lightsSize);
  if (millis() % 1000 == 0) {
    button1.Print();
    button2.Print();
  }

  if (!timerIsSet) {
    if (button1.Read()) {

    } else if (button2.Read()) {

    }
  } else {

    timerIsSet = false;
  }

  if (Serial.available()) {
    char readChar  = (char)Serial.read();
    Serial.println(readChar);
    /*
      switch (readChar) {
      case 'a':
        lights[0].Burn(1000, 0);
        break;
      case 'b':
        lights[1].Burn(1000, 0);
        break;
      case 'c':
        lights[2].Burn(1000, 0);
        break;
      case 'd':
        lights[3].Burn(1000, 0);
        break;
      case 'e':
        lights[0].Burn(random(0, 5000), random(0, 1000));
        lights[1].Burn(random(0, 5000), random(0, 1000));
        lights[2].Burn(random(0, 5000), random(0, 1000));
        lights[3].Burn(random(0, 5000), random(0, 1000));
        break;
      case 'f':
        FollowSequence(lights, lightsSize, 'l', 1000);
        break;
      case 'g':
        FollowSequence(lights, lightsSize, 'r', 1000);
        break;
      case 'p':
        PrintLights(lights, lightsSize);
        break;
      }
    */
  }
}
