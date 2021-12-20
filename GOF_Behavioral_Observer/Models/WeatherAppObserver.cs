using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_Observer.Models.Interfaces;

namespace GOF_Behavioral_Observer.Models
{
    class WeatherAppObserver : IObserver
    {
        private int _temperature;
        private readonly ISubject _subject;
        public WeatherAppObserver(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }
        public void Update(int temperature)
        {
            _temperature = temperature;
            Display();
        }

        public void PullTemperature()
        {
            if (_subject is WeatherSubject)
            {
                var sub = (WeatherSubject) _subject;
                _temperature = sub.GetTemperature();
                Display();
            }

        }

        public void UnregisterMyself()
        {
            _subject.RemoveObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current temperature is " + _temperature + " in WeatherAppObserver");
        }
    }
}
