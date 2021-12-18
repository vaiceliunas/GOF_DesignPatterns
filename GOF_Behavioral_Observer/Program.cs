using System;
using GOF_Behavioral_Observer.Models;

namespace GOF_Behavioral_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var sub = new WeatherSubject();

            var obs1 = new NationalWeatherWebsiteObserver();
            var obs2 = new WeatherAppObserver();

            sub.RegisterObserver(obs1);
            sub.RegisterObserver(obs2);

            sub.TemperatureChanged(50);
            Console.WriteLine(".....");
            sub.RemoveObserver(obs2);

            sub.TemperatureChanged(80);

            Console.ReadLine();
        }
    }
}
