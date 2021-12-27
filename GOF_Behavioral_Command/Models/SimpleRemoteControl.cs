using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_Command.Models.Commands;
using GOF_Behavioral_Command.Models.Interfaces;

namespace GOF_Behavioral_Command
{
    public class SimpleRemoteControl
    {
        private readonly ICommand[] _commands;
        private ICommand _undoCommand;

        public SimpleRemoteControl()
        {
            _commands = new ICommand[10];
            _undoCommand = new NoCommand();
            for (var i = 0; i < _commands.Length; i++)
            {
                _commands[i] = new NoCommand();
            }
        }
        public void SetCommand(ICommand command, int slotNumber)
        {
            if (!IsSlotNumberLegit(slotNumber))
                return;

            _commands[slotNumber] = command;
        }

        public void ButtonWasPressed(int slotNumber)
        {
            if (!IsSlotNumberLegit(slotNumber))
                return;

            _commands[slotNumber].Execute();
            _undoCommand = _commands[slotNumber];
        }

        public void UndoWasPressed()
        {
            _undoCommand.Undo();
        }

        private bool IsSlotNumberLegit(int slotNumber)
        {
            return (slotNumber < _commands.Length - 1) && (slotNumber >= 0);
        }
    }
}
