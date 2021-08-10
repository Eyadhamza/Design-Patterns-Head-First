using System;
using System.Collections;
using System.Collections.Generic;
using Head_First_Design_Patterns.Contracts;

namespace Head_First_Design_Patterns.Models
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;

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
    }
}
