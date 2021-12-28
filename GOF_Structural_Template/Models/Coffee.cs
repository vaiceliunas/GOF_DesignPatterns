using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Structural_Template.Models.Interfaces;

namespace GOF_Structural_Template.Models
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brewing coffee grinds");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar");
        }
    }
}
