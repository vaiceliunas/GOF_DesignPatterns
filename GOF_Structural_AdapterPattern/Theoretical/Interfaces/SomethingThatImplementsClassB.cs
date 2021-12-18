using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_AdapterPattern.Theoretical.Interfaces
{
    public class SomethingThatImplementsClassB
    {
        private readonly IClassB classB;

        public SomethingThatImplementsClassB(IClassB ClassB)
        {
            classB = ClassB;
        }

        public void DoStuff()
        {
            classB.CallClassB();
        }
    }
}
