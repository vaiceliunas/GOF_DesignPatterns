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
        public void Update(int temperature)
        {
            _temperature = temperature;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current temperature is " + _temperature + " in WeatherAppObserver");
        }
    }
}
