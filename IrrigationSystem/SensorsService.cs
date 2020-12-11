using System;
using System.Collections.Generic;
using System.Text;

namespace IrrigationSystem
{
    public class SensorsService
    {
        private RainSensor rainSensor; // датчик дождя
        private SoilMoistureSensor soilMoistureSensor; // дадчик влажности почвы
        private TemperatureSensor temperatureSensor; // датчик температуры воздуха
    }
}
