using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Behavioral_State.Models
{
    public class GumballMachineFirstTry
    {
        public static readonly int SoldOut = 0;
        public static readonly int NoQuarter = 1;
        public static readonly int HasQuarter = 2;
        public static readonly int Sold = 3;

        private int _state = SoldOut;
        private int _count = 0;

        public GumballMachineFirstTry(int count)
        {
            _count = count;
            if (_count > 0)
                _state = NoQuarter;
        }

        public void InsertQuarter()
        {
            if(_state == HasQuarter)
                Console.WriteLine("Cannot insert another quarter cuz quarter is inserted already");

            if (_state == SoldOut)
                Console.WriteLine("You can't insert a quarter, machine is sold out");

            if(_state == Sold)
                Console.Write("Please wait, we are giving you a gumball");

            if (_state == NoQuarter)
            {
                _state = HasQuarter;
                Console.WriteLine("You've inserted a quarter");
            }
        }

        public void EjectQuarter()
        {
            if(_state == NoQuarter)
                Console.WriteLine("There is no quarter inserted");

            if(_state == Sold)
                Console.WriteLine("You've already turned the crank, cannot eject");

            if(_state == SoldOut)
                Console.WriteLine("Cannot eject, you haven't inserted quarter yet.");

            if (_state == HasQuarter)
            {
                _state = NoQuarter;
                Console.WriteLine("Quarter returned");
            }
        }

        public void TurnCrank()
        {
            if(_state == Sold)
                Console.WriteLine("Turning crank twice doesn't get you another gumball.");

            if(_state == NoQuarter)
                Console.WriteLine("You've turned but there is no quarter");

            if(_state == SoldOut)
                Console.WriteLine("You've turned, but there is no gumballs");

            if (_state == HasQuarter)
            {
                Console.WriteLine("You've turned...");
                _state = Sold;
                Dispense();
            }
        }

        public void Dispense()
        {
            if(_state == NoQuarter)
                Console.WriteLine("You need to pay first");

            if(_state == SoldOut)
                Console.WriteLine("No gumball dispensed");

            if(_state == HasQuarter)
                Console.WriteLine("No gumball dispensed");

            if (_state == Sold)
            {
                Console.WriteLine("Gumball comes rolling out the slot");
                _count = _count - 1;
                if (_count == 0)
                {
                    Console.WriteLine("Out of gumballs!");
                    _state = SoldOut;
                }
                else
                {
                    _state = NoQuarter;
                }
            }
        }

        public void CurrentState()
        {
            if(_state == SoldOut)
                Console.WriteLine("Current state - SoldOut");

            if (_state == NoQuarter)
                Console.WriteLine("Current state - NoQuarter");

            if (_state == HasQuarter)
                Console.WriteLine("Current state - HasQuarter");

            if (_state == Sold)
                Console.WriteLine("Current state - Sold");
        }
    }
}
