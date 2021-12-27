using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_Facade.Models.Interfaces
{
    public interface IPopcornPopper
    {
        public void TurnOn();
        public void Make();
        public void PutIntoBox();
    }
}
