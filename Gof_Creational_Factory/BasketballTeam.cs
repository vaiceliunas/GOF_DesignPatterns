using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof_Creational_Factory
{
    public class BasketballTeam : ITeam
    {
        private string Name { get; set; }

        public ITeam CreateTeam()
        {
            return new BasketballTeam();
        }
    }
}
