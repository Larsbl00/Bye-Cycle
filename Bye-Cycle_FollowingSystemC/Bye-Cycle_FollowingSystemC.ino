#include <Arduino.h>
#include <string.h>
#include "ldr.h"
#include "lights.h"
#include "button.h"

#define ldr A0

//Located on pins 2, 4, 7, 8
Lights lights[4] = {CreateLights(2, &PORTD, &DDRD), CreateLights(4, &PORTD, &DDRD), CreateLights(7, &PORTD, &DDRD), CreateLights(0, &PORTB, &DDRB)};

//Located on pins 10, 11
Button buttons1[] = {CreateButton(2, &PINB, &DDRB), CreateButton(3, &PINB, &DDRB)};

//Located on pins 5, 6
Button buttons2[] = {CreateButton(5, &PIND, &DDRD), CreateButton(6, &PIND, &DDRD)};

bool systemIsOn = true;
bool lastTimeSystemOn;
String serialInput;
const uint8_t lightsSize =  sizeof(lights) / sizeof(Lights);

//This event is triggered when something was recieved in the serialport
void serialEvent() {
  serialInput = "";
  while (Serial.available()) {
    serialInput += (char)Serial.read();
    delayMicroseconds(250);
  }
  Serial.println(serialInput);
  //Sample protocol: %<DestinationLetter>:<Command>-<Value>#
  if (serialInput != "" && serialInput.charAt(0) == '%' && serialInput.charAt(1) == 'F' && serialInput.indexOf('#') != -1) {
    String varToChange = serialInput.substring(3, serialInput.indexOf('-'));
    uint8_t value = serialInput.substring(serialInput.indexOf('-') + 1, serialInput.indexOf('#')).toInt();
    //Sample turn-on protocol: %F:followOff-0#
    if (varToChange == "followOff") {
      systemIsOn = !(bool)value;
    }
  }
}

void setup() {
  Serial.begin(38400);
  pinMode(13, OUTPUT);
}

void loop() {
  //Calls the check funtion on lights, to determine if they should be on
  CheckLightArray(lights, lightsSize);

  if (IsDark(ldr)) {
    if (systemIsOn) {
      CheckButtonSet(buttons1, 2, lights, lightsSize);
      CheckButtonSet(buttons2, 2, lights, lightsSize);
    } else {
      for (int i = 0; i < lightsSize; i++) {
        Burn(&lights[i], 1, 0);
      }
    }
  }
  lastTimeSystemOn = systemIsOn;
}
