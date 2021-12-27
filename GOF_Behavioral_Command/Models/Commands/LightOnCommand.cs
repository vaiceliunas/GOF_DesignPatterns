using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_Command.Models.Interfaces;

namespace GOF_Behavioral_Command.Models
{
    class LightOnCommand : ICommand
    {
        private ILight _light;

        public LightOnCommand(ILight light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
