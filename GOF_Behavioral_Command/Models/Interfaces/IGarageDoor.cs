using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Behavioral_Command.Models.Interfaces
{
    public interface IGarageDoor
    {
        public void Up();
        public void Down();
        public void Stop();
        public void LightOn();
        public void LightOff();
    }
}
