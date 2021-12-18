using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_AdapterPattern.Pratcical
{
    class RegularWorkerToPlayerAdapter : IPlayer
    {
        private RegularWorker RegularWorker { get; set; }
        public RegularWorkerToPlayerAdapter(RegularWorker rWorker)
        {
            RegularWorker = rWorker;
        }
        public void DoPresentation()
        {
            Console.WriteLine("Parameters of height and weight are unknown");
        }
    }
}
