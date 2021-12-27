using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_Command.Models.Interfaces;

namespace GOF_Behavioral_Command.Models.Commands
{
    public class MacroCommand : ICommand
    {
        private ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }
        public void Execute()
        {
            for (var i = 0; i < _commands.Length; i++)
            {
                _commands[i].Execute();
            }
        }

        public void Undo()
        {
            Console.WriteLine("Macro command does not support undo");
        }
    }
}
