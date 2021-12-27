using System;
using GOF_Behavioral_Command.Models;
using GOF_Behavioral_Command.Models.Commands;

namespace GOF_Behavioral_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new SimpleRemoteControl();

            var lightCommand = new LightOnCommand(new Light("kitchen"));
            var lightCommand2 = new LightOnCommand(new Light("living room"));
            var openDoorCommand = new GarageDoorOpenCommand(new GarageDoor());
            
            remoteControl.SetCommand(lightCommand,0);
            remoteControl.SetCommand(lightCommand2, 1);
            remoteControl.SetCommand(openDoorCommand, 2);
            
            remoteControl.ButtonWasPressed(0);
            remoteControl.ButtonWasPressed(1);
            remoteControl.ButtonWasPressed(2);

            remoteControl.UndoWasPressed();

            remoteControl.ButtonWasPressed(3);



            Console.ReadLine();
        }
    }
}
