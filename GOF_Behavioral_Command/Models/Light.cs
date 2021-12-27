using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_Command.Models.Interfaces;

namespace GOF_Behavioral_Command.Models
{
    public class Light : ILight
    {
        private string _roomName;

        public Light(string roomName)
        {
            _roomName = roomName;
        }
        public void On()
        {
            Console.WriteLine("Light on! " + _roomName);
        }

        public void Off()
        {
            Console.WriteLine("Light Off " + _roomName);
        }

    }
}
