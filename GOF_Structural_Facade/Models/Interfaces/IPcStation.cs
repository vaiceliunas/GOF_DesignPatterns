using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_Facade.Models.Interfaces
{
    public interface IPcStation
    {
        public void RunVlc();
        public void SetMovie();
        public void DownloadMovie();
        public void RecognizeMovieName();
        public void TurnOn();
        public void Play();
    }
}
