using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Structural_Adapter.Duck_example.Models.Interfaces;

namespace GOF_Structural_Adapter.Duck_example.Models
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Wild turkey Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Wild turkey flying");
        }
    }
}
