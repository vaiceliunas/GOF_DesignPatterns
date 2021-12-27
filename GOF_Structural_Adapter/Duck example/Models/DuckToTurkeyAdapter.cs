using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Structural_Adapter.Duck_example.Models.Interfaces;
using GOF_Structural_Adapter.Models.Interfaces;

namespace GOF_Structural_Adapter.Duck_example.Models
{
    public class DuckToTurkeyAdapter : ITurkey
    {
        private IDuck _duck;
        public DuckToTurkeyAdapter(IDuck duck)
        {
            _duck = duck;
        }

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            _duck.Fly();
        }
    }
}
