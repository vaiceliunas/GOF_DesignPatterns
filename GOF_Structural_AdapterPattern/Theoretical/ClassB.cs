using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_AdapterPattern.Theoretical.Interfaces
{
    class ClassB : IClassB
    {
        public void CallClassB()
        {
            Console.WriteLine("Call class B!");
        }
    }
}
