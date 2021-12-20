using System;
using GOF_Creational_Abstract_Factory.Models.Interfaces;

namespace GOF_Creational_Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var toDoGoalStore = new ToDoGoalStore();
            var toAvoidGoalStore = new ToAvoidGoalStore();

            var goal1 = toAvoidGoalStore.CreateGoal("sport");
            var goal2 = toDoGoalStore.CreateGoal("sport");

            goal1.CurrentStatus();
            goal2.CurrentStatus();

            Console.ReadLine();
        }
    }
}
