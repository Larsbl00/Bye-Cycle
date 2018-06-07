#ifndef _WATERSENSOR_H
#define _WATERSENSOR_H
#define rainSensor A0
#define standardTime 2000
#define rainTime 1000
void waterSensor_measurement_mode();
void waterSensor_change_interval(int sensorValue);

long TimerInterval();
void TimerInterval(long value);

#endif
