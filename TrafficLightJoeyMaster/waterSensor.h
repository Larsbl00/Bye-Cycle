#ifndef _WATERSENSOR_H
#define _WATERSENSOR_H

int waterSensor_measurement_mode(int *sensorValue);
int waterSensor_change_interval(int *sensorValue, long *timer);
#endif
