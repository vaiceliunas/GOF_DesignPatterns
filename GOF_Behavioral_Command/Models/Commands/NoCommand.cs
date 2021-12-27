using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_Command.Models.Interfaces;

namespace GOF_Behavioral_Command.Models.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No command assigned");
        }

        public void Undo()
        {
            Console.WriteLine("No command assigned");
        }
    }
}
