using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof_Creational_Factory
{
    public interface ITeam
    {
        public ITeam CreateTeam();
    }
}
