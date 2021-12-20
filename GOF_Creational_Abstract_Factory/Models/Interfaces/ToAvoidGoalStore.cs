using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Creational_Abstract_Factory.Models.Interfaces
{
    class ToAvoidGoalStore : IGoalSettingStore
    {
        public IGoal CreateGoal(string type)
        {
            if (type == "sport")
                return new StopEatingJunkFoodGoal();
            if (type == "mental")
                return new StopWatchingTvGoal();

            throw new Exception("unable to create ToDo goal (invalid type)");
        }
    }
}
