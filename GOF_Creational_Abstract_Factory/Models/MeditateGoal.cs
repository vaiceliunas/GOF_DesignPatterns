using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Creational_Abstract_Factory.Models.Interfaces;

namespace GOF_Creational_Abstract_Factory.Models
{
    class MeditateGoal : IGoal
    {
        public void CurrentStatus()
        {
            Console.WriteLine("Meditate goal incoming!");
        }
    }
}
