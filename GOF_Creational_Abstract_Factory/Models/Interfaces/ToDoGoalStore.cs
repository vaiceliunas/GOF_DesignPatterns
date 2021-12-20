using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Creational_Abstract_Factory.Models.Interfaces
{
    class ToDoGoalStore : IGoalSettingStore
    {
        public IGoal CreateGoal(string type)
        {
            if (type == "sport")
                return new PullUpsGoal();
            if (type == "mental")
                return new MeditateGoal();

            throw new Exception("unable to create ToDo goal (invalid type)");
        }
    }
}
