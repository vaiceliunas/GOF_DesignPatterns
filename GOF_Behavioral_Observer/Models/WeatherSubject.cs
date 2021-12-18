using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_Observer.Models.Interfaces;

namespace GOF_Behavioral_Observer.Models
{
    public class WeatherSubject : ISubject
    {
        private List<IObserver> _observers;
        private int _temperature;

        public WeatherSubject()
        {
            _observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        { 
            var index = _observers.IndexOf(observer);
            if(index >= 0)
                _observers.RemoveAt(index);
        }

        public void TemperatureChanged(int temperature)
        {
            _temperature = temperature;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                o.Update(_temperature);
            }
        }
    }
}
