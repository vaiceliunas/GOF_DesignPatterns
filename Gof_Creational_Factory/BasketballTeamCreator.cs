using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof_Creational_Factory.Interfaces
{
    class BasketballTeamCreator : ITeamCreator
    {
        public ITeam CreateInstance()
        {
            return new BasketballTeam();
        }
    }
}
