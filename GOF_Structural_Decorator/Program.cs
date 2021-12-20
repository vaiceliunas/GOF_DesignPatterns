using System;
using GOF_Structural_Decorator.Models;
using GOF_Structural_Decorator.Models.Interfaces;

namespace GOF_Structural_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Soy(new Soy(new Espresso()));
            Console.WriteLine(obj.Cost());
            Console.WriteLine(obj.GetDescription());

            obj.SetCupSize(5);
            var objWithDiscount = new ChristmasDiscount(obj);
            Console.WriteLine("With discount");
            Console.WriteLine(objWithDiscount.Cost());

            Console.ReadLine();

            
        }
    }
}
