using System;
using GOF_Behavioral_State.Models;

namespace GOF_Behavioral_State
{
    class Program
    {
        static void Main(string[] args)
        {
            //var gumballMachine = new GumballMachineFirstTry(5);

            //gumballMachine.CurrentState();
            
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();

            //gumballMachine.CurrentState();

            //gumballMachine.InsertQuarter();
            //gumballMachine.EjectQuarter();
            //gumballMachine.TurnCrank();

            //gumballMachine.CurrentState();

            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.EjectQuarter();

            //gumballMachine.CurrentState();

            //gumballMachine.InsertQuarter();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();

            //gumballMachine.CurrentState();

            var gumballMachine = new GumballMachineReworked(5);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.ReadLine();
        }
    }
}
