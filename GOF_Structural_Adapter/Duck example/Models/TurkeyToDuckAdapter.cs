using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Structural_Adapter.Duck_example.Models.Interfaces;
using GOF_Structural_Adapter.Models.Interfaces;

namespace GOF_Structural_Adapter.Duck_example.Models
{
    public class TurkeyToDuckAdapter : IDuck
    {
        private ITurkey _turkey;

        public TurkeyToDuckAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }


        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            _turkey.Fly();
        }
    }
}
