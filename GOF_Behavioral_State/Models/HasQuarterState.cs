using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_State.Models.Interfaces;

namespace GOF_Behavioral_State.Models
{
    public class HasQuarterState: IState
    {
        private Random _randomWinner = new Random();
        private GumballMachineReworked _gumballMachine;

        public HasQuarterState(GumballMachineReworked gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned crank..");

            int winner = _randomWinner.Next(0, 10);
            if(winner == 0)
                _gumballMachine.SetState(_gumballMachine.GetWinnerState());
            else
                _gumballMachine.SetState(_gumballMachine.GetSoldState());
            }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }

        public void CurrentState()
        {
            Console.WriteLine("Current state is 'HasQuarter'");
        }
    }
}
