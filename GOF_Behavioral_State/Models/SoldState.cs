using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_State.Models.Interfaces;

namespace GOF_Behavioral_State.Models
{
    public class SoldState : IState
    {
        private GumballMachineReworked _gumballMachine;

        public SoldState(GumballMachineReworked gumballMachine)
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
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.GetCount() > 0)
                _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
            else
            {
                Console.WriteLine("We are out of gumballs!");
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
            }
        }

        public void CurrentState()
        {
            throw new NotImplementedException();
        }
    }
}
