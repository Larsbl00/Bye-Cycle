#include "trafficLight.h"
#include "communicationI2C.h"
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
  unsigned long currentMillis = millis();
  TimerInterval(1000);
  if (currentMillis - previousMillis >= TimerInterval())
  {
    previousMillis = currentMillis;
    recieveMessage();

    if (strcmp(CurrentState(), 'o') == 0 && strcmp(LastState(), 'r') == 0 )
    {
      Serial.print("Currenstate  afterstrcmp: ");
      Serial.println(CurrentState());
      Serial.print("LastState afterstrcmp: ");
      Serial.println(LastState());
      modes('o');
    }

    else if (strcmp(CurrentState(), 'g')  == 0 && strcmp(LastState(), 'r') == 0 )
    {
      Serial.println("g - r");
      modes('r');
    }

    else if (strcmp(CurrentState(), 'r')== 0 && strcmp(LastState(), 'o' ) == 0 )
    {
      Serial.println("r - o");
      modes('r');
    }

    else if (strcmp(CurrentState(), 'r' )== 0  && strcmp(LastState(), 'g') == 0 )
    {
      Serial.println("r - g");
      modes('g');
    }
  }


}
