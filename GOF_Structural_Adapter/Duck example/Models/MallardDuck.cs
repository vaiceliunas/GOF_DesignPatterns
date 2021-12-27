using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Structural_Adapter.Models.Interfaces;

namespace GOF_Structural_Adapter.Duck_example.Models
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Mallard quack");
        }

        public void Fly()
        {
            Console.WriteLine("Mallard flying");
        }
    }
}
