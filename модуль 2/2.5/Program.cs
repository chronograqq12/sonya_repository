using System;
namespace _2._5
{
    //делегат задает сигнатуру метода-обработчика события
    delegate void TemperatureHandler(int temp);
    //класс датчика температуры, генерирующий событие при изменении значения
    class TemperatureSensor
    {
        //объявление события на основе делегата
        public event TemperatureHandler TemperatureChanged;
        private int temperature;
        // свойство для установки и получения температуры
        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (temperature != value)
                {
                    temperature = value;

                    //если есть подписчики, вызываем событие
                    if (TemperatureChanged != null)
                    {
                        TemperatureChanged(temperature);
                    }
                }
            }
        }
    }
    //класс термостата, реагирующий на изменение температуры
    class Thermostat
    {
        public void OnTemperatureChanged(int currentTemp)
        {
            if (currentTemp < 20)
            {
                Console.WriteLine("температура упала до " + currentTemp + "°C. включаем отопление.");
            }
            else
            {
                Console.WriteLine("температура поднялась до " + currentTemp + "°C. выключаем отопление.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();
            Thermostat thermostat = new Thermostat();
            //подписываем метод термостата на событие датчика
            sensor.TemperatureChanged += thermostat.OnTemperatureChanged;
            //изменяем значения температуры, что приводит к срабатыванию события
            sensor.Temperature = 18;
            sensor.Temperature = 22;
        }
    }
}