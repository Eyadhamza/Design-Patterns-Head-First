using System;
using Head_First_Design_Patterns.Contracts;
using Head_First_Design_Patterns.Models;

namespace Head_First_Design_Patterns.Displays
{
    public class CurrentConditionsDisplay : IDisplayElement,IObserver
    {
        private float _temprature;
        private float _humdity;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }


        public void Update()
        {
            _temprature = _weatherData.Temperature;
            _humdity = _weatherData.Humidity;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Current Conditions" + _temprature + "F degrees and " + _humdity + "% humidity");
        }
    }
}
