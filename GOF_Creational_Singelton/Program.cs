using System;

namespace GOF_Creational_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //can be seen in debug. first time its created, second tame same object is taken.
            var instance = SingletonInstance.GetInstance();
            var instance2 = SingletonInstance.GetInstance();

            Console.WriteLine("Hello World!");
        }
    }
}
