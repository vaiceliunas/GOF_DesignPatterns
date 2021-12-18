using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Structural_AdapterPattern.Theoretical.Interfaces;

namespace GOF_Structural_AdapterPattern.Theoretical
{
    public class ClassA : IClassA
    {
        public void CallClassA()
        {
            Console.WriteLine("Call class A!");
        }
    }
}
