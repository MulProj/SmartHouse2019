﻿using System.Collections.Generic;

namespace WebApplication3.Models.Interfaces
{
    public interface ISensorRepository
    {
        List<Sensor> GetAllSensors();
        Sensor GetSensor(int sensorId);
        int AddTemperatureSensor(TemperatureSensor sensor, House house);
        int AddHumiditySensor(HumiditySensor sensor, House house);
        int AddSmokeSensor(SmokeSensor sensor, House house);
        int AddMotionSensor(MotionSensor sensor, House house);
        int UpdateTemperatureSensor(TemperatureSensor sensor);
        int UpdateHumiditySensor(HumiditySensor sensor);
        int UpdateSmokeSensor(SmokeSensor sensor);
        int UpdateMotionSensor(MotionSensor sensor);
        void DeleteSensor(Sensor sensor);
    }
}
