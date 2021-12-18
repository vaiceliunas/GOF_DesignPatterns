using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Structural_AdapterPattern.Theoretical.Interfaces;

namespace GOF_Structural_AdapterPattern.Theoretical
{
    class AtoBAdapter : IClassB
    {
        public readonly ClassA classA;

        public AtoBAdapter(ClassA ClassA)
        {
            classA = ClassA;
        }
        public void CallClassB()
        {
            //do stuff thats needed for a class to call class b
            classA.CallClassA();
            Console.WriteLine("Call class B!");
        }
    }
}
