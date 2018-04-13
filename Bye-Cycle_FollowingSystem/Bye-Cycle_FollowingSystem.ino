#include <Arduino.h>
#include "ldr.h"
#include "lights.h"
#include "button.h"

#define ldr A0

Lights lights[] = {Lights (2, &PORTD, &DDRD), Lights(4, &PORTD, &DDRD), Lights(7, &PORTD, &DDRD), Lights(0, &PORTB, &DDRB)};

Button button1 = Button(2, &PINB, &DDRB);
Button button2 = Button(3, &PINB, &DDRB);

bool systemIsOn = true;
const uint8_t lightsSize =  sizeof(lights) / sizeof(Lights);

void setup() {
  Serial.begin(9600);
  PrintLights(lights, lightsSize);
  button1.Print();
  button2.Print();
}

void loop() {
  CheckLightArray(lights, lightsSize);
  if (systemIsOn && IsDark(ldr)) {
    button1.Read();
    button2.Read();
    if (button1.IsSet() && button2.IsSet()) {
      long difference = button1.LastTimeActive() - button2.LastTimeActive();
      if (difference > 0) {
        //Button1 was pressed later than Button2
        long TimeToBurn = (abs(difference) * DistanceBetweenLightPosts / DistanceBetweenButtonsInPair);
        FollowSequence(lights, lightsSize, 'l', TimeToBurn);
      } else if (difference < 0) {
        //Button2 was pressed later than Button1
        long TimeToBurn = (abs(difference) * DistanceBetweenLightPosts / DistanceBetweenButtonsInPair);
        FollowSequence(lights, lightsSize, 'r', TimeToBurn);
      } else {
        //There was no delay detected
        long TimeToBurn = (5000 * DistanceBetweenLightPosts / DistanceBetweenButtonsInPair);
        for (int i = 0; i < lightsSize; i++) {
          lights[i].Burn(TimeToBurn, 0);
        }
      }
      button1.IsSet(false);
      button2.IsSet(false);
    }
  }
}
