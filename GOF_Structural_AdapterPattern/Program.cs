using System;
using GOF_Structural_AdapterPattern.Pratcical;
using GOF_Structural_AdapterPattern.Theoretical;
using GOF_Structural_AdapterPattern.Theoretical.Interfaces;

namespace GOF_Structural_AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Theoretical
            //var classA = new ClassA();
            //var adapted = new AtoBAdapter(classA);
            //var smth = new SomethingThatImplementsClassB(adapted);
            //smth.DoStuff();


            var regularWorker = new RegularWorker();
            var player = Player.CreateInstance(190, 80);

            var service1 = new PlayerEditionService(player);
            service1.PresentPlayerInfo();

            var service2 = new PlayerEditionService(new RegularWorkerToPlayerAdapter(regularWorker));
            service2.PresentPlayerInfo();


            Console.ReadLine();
        }
    }
}
