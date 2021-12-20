﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Creational_Abstract_Factory.Models.Interfaces
{
    public interface IGoalSettingStore
    {
        public IGoal CreateGoal(string type);
    }
}
