#include <Arduino.h>
#include "ldr.h"

#define minimumValue 970

int returnPercentage(int analogValue) {
  
  if(analogValue < minimumValue){
      return 0;
  } else {
      int returnValue = map(analogValue, minimumValue, 1023, 0, 100);
      return returnValue;
  }
}
