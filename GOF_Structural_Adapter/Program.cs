using System;
using GOF_Structural_Adapter.Duck_example.Models;
using GOF_Structural_Adapter.Duck_example.Models.Interfaces;
using GOF_Structural_Adapter.Models.Interfaces;

namespace GOF_Structural_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var turkey = new WildTurkey();
            var turkeyWithDuckCostume = new TurkeyToDuckAdapter(turkey);
            Program.TakeADuckAndDoSomeStuff(turkeyWithDuckCostume);

            var duck = new MallardDuck();
            var duckWithTurkeyCostume = new DuckToTurkeyAdapter(duck);
            Program.TakeATurkeyAndDoSomeStuff(duckWithTurkeyCostume);

            Console.ReadLine();
        }

        static void TakeADuckAndDoSomeStuff(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }

        static void TakeATurkeyAndDoSomeStuff(ITurkey turkey)
        {
            turkey.Fly();
            turkey.Gobble();
        }
    }
}
