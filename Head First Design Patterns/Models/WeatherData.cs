using System;
using System.Collections;
using System.Collections.Generic;
using Head_First_Design_Patterns.Contracts;

namespace Head_First_Design_Patterns.Models
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;

        public List<IObserver> Observers
        {
            get => _observers;
            set => _observers = value;
        }

        public float Temperature
        {
            get => _temperature;
            set => _temperature = value;
        }

        public float Humidity
        {
            get => _humidity;
            set => _humidity = value;
        }

        public float Pressure
        {
            get => _pressure;
            set => _pressure = value;
        }

        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }



        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
