using System;
using Gof_Creational_Factory.Interfaces;

namespace Gof_Creational_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //some statment that checks if basketball team needs to be created;
            //if()

            var bsCreator = new BasketballTeamCreator();
            var obj = bsCreator.CreateInstance();
        }
    }
}
