using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_AdapterPattern.Pratcical
{
    public class PlayerEditionService
    {
        private IPlayer Player { get; set; }

        public PlayerEditionService(IPlayer player)
        {
            Player = player;
        }

        public void PresentPlayerInfo()
        {
            Player.DoPresentation();
        }
    }
}
