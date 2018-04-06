#include <Arduino.h>
#include "ldr.h"
#include "lights.h"


const Lights lights[] = {Lights (2, &PORTD, &DDRD), Lights(4, &PORTD, &DDRD), Lights(7, &PORTD, &DDRD), Lights(0, &PORTB, &DDRB)};
const uint8_t lightsSize =  sizeof(lights) / sizeof(Lights);
Lights reversedLights[(int)lightsSize] = {Lights(0, NULL, NULL), Lights(0, NULL, NULL), Lights(0, NULL, NULL), Lights(0, NULL, NULL)};

void setup() {
  Serial.begin(9600);
  FlipArray(lights, reversedLights, lightsSize);
  PrintLights(lights, lightsSize);
  PrintLights(reversedLights, lightsSize);

}

void loop() {
  CheckLightArray(lights, lightsSize);
  switch ((char)Serial.read()) {
    case 'a':
      lights[0].Burn(4000);
      break;
    case 'b':
      lights[1].Burn(4000);
      break;
    case 'c':
      lights[2].Burn(4000);
      break;
    case 'd':
      lights[3].Burn(4000);
      break;
    case 'e':
      lights[0].Burn(1000);
      lights[1].Burn(2000);
      lights[2].Burn(3000);
      lights[3].Burn(4000);
      break;
  }

}
