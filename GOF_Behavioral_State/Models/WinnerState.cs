using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_State.Models.Interfaces;

namespace GOF_Behavioral_State.Models
{
    public class WinnerState : IState
    {
        private GumballMachineReworked _gumballMachine;

        public WinnerState(GumballMachineReworked gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already tuned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning crank twice doesn't get you another gumball");
        }
        public void Dispense()
        {
            Console.WriteLine("You are a winner! you get two");
            _gumballMachine.ReleaseBall();
            Console.WriteLine("One ball released");
            if (_gumballMachine.GetCount() == 0)
            {
                Console.WriteLine("Unfortunately there are no more gumballs. Stack is empty. Only one was released.");
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
                return;
            }

            _gumballMachine.ReleaseBall();
            Console.WriteLine("another released");
            if(_gumballMachine.GetCount() > 0)
                _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
            else
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());

        }

        public void CurrentState()
        {
            throw new NotImplementedException();
        }
    }
}
