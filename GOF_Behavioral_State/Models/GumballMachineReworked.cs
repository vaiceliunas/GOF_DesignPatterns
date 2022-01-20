using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOF_Behavioral_State.Models.Interfaces;

namespace GOF_Behavioral_State.Models
{
    public class GumballMachineReworked
    {
        private IState _soldOutState;
        private IState _noQuarterState;
        private IState _hasQuarterState;
        private IState _soldState;
        private IState _winnerState;

        private IState _state;
        private int _count = 0;

        public GumballMachineReworked(int numberOfGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);
            _count = numberOfGumballs;
            if (_count > 0)
                _state = _noQuarterState;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }


        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            if (_count > 0)
            {
                Console.WriteLine("A gumball comes rolling out the slot...");
                _count = _count - 1;
            }
            else
                Console.WriteLine("There are no gumballs to be released");
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }

        public int GetCount()
        {
            return _count;
        }

        public void Refill(int amount)
        {
            _count = _count + amount;

            if (_count > 0)
                _state = _noQuarterState;
            else
                _state = _soldOutState;
        }
    }
}
