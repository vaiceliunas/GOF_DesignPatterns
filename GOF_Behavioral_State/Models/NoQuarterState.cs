using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_State.Models;
using GOF_Behavioral_State.Models.Interfaces;

namespace GOF_Behavioral_State
{
    public class NoQuarterState : IState
    {
        private GumballMachineReworked _gumballMachine;

        public NoQuarterState(GumballMachineReworked gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first!");
        }

        public void CurrentState()
        {
            throw new NotImplementedException();
        }
    }
}
