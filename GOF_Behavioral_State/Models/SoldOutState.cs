using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_State.Models.Interfaces;

namespace GOF_Behavioral_State.Models
{
    class SoldOutState : IState
    {
        private GumballMachineReworked _gumballMachine;

        public SoldOutState(GumballMachineReworked gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sorry, we are sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, we are sold out + there is no coin inserted");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Sorry, we are sold out, plus you haven't inserted a coin");
        }

        public void Dispense()
        {
            Console.WriteLine("Sorry, we are sold out");
        }

        public void CurrentState()
        {
            Console.WriteLine("Current state is 'SoldOut'");
        }
    }
}
