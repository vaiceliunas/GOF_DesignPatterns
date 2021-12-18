using System;
using GOF_Behavioral_Observer.Models;

namespace GOF_Behavioral_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var sub = new WeatherSubject();

            var obs1 = new NationalWeatherWebsiteObserver(sub);
            var obs2 = new WeatherAppObserver(sub);

            sub.TemperatureChanged(50);
            Console.WriteLine(".....");
            obs2.UnregisterMyself();

            sub.TemperatureChanged(80);

            Console.ReadLine();
        }
    }
}
