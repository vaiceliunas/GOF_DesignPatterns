using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_Command.Models.Interfaces;

namespace GOF_Behavioral_Command.Models.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private IGarageDoor _garageDoor;

        public GarageDoorOpenCommand(IGarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.LightOn();
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
            _garageDoor.LightOff();
        }
    }
}
