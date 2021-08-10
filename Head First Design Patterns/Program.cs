using System;
using Head_First_Design_Patterns.Displays;
using Head_First_Design_Patterns.Models;

namespace Head_First_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurements(80,70,15);
            weatherData.SetMeasurements(81,72,13);
            weatherData.SetMeasurements(10,755,11);
        }
    }
}
