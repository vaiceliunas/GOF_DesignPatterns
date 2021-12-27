using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_Command.Models.Interfaces;

namespace GOF_Behavioral_Command.Models
{
    public class GarageDoor : IGarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door up!");
        }

        public void Down()
        {
            Console.WriteLine("Garage door down!");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door stop!");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door lighting on!");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door lighting off!");
        }
    }
}
