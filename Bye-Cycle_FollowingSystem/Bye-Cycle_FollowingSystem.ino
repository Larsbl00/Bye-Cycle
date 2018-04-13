#include <Arduino.h>
#include "ldr.h"
#include "lights.h"
#include "button.h"

Lights lights[] = {Lights (2, &PORTD, &DDRD), Lights(4, &PORTD, &DDRD), Lights(7, &PORTD, &DDRD), Lights(0, &PORTB, &DDRB)};

Button button1 = Button(2, &PINB, &DDRB);
Button button2 = Button(3, &PINB, &DDRB);

const uint8_t lightsSize =  sizeof(lights) / sizeof(Lights);

void setup() {
  Serial.begin(9600);
  PrintLights(lights, lightsSize);
  button1.Print();
  button2.Print();
}

void loop() {
  CheckLightArray(lights, lightsSize);
  button1.Read();
  button2.Read();

  if (button1.IsSet() && button2.IsSet()) {
    long difference = button1.LastTimeActive() - button2.LastTimeActive();
    Serial.println(abs(difference));
    if (difference > 0) {
      //Button1 was pressed later than Button2
      FollowSequence(lights, lightsSize, 'l', abs(difference));
    } else if (difference < 0) {
      //Button2 was pressed later than Button1
      FollowSequence(lights, lightsSize, 'r', abs(difference));
    } else {
      //There was no delay detected
      for (int i = 0; i < lightsSize; i++) {
        lights[i].Burn(5000, 0);
      }
    }
    button1.IsSet(false);
    button2.IsSet(false);
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
