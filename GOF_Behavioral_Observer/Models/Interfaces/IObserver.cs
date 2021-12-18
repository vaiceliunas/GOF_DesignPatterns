using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Behavioral_Observer.Models.Interfaces
{
    public interface IObserver
    {
        public void Update(int temperature);
    }
}
