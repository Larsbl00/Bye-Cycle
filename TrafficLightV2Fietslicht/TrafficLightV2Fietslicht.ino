#include "trafficLight.h"
#include "communicationI2C.h"
char state = 'r';

unsigned long previousMillis = 1000;

void setup() {

  pinMode(ledGreen, OUTPUT);
  pinMode(ledOrange, OUTPUT);
  pinMode(ledRed, OUTPUT);

  Serial.begin(9600);
  Serial.println("----------------------------------------------------");
  Serial.println("Serial is online");
  Serial.println("----------------------------------------------------");
}

void loop()
{
//default mode mode('r');
  unsigned long currentMillis = millis();
  TimerInterval(1000);
  if (currentMillis - previousMillis >= TimerInterval())
  {
    previousMillis = currentMillis;

    if (state == 'r') {
      state = 'o';
      sendMessage(&state);
     // modes(&state);
    }
    else if (state == 'o') {
      state = 'g';
      sendMessage(&state);
      //modes(&state);
    }
    else if  (state == 'g') {
      state = 'r';
      sendMessage(&state);
    //  modes(&state);
    }
  }


}
