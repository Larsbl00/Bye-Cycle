#ifndef _WATERSENSOR_H
#define _WATERSENSOR_H

int waterSensor_measurement_mode(int *sensorValue);
int waterSensor_Change_Interval(int *sensorValue, long *timer);
#endif
