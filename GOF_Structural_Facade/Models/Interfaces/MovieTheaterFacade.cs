using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_Facade.Models.Interfaces
{
    public class MovieTheaterFacade
    {
        private IPcStation _pcStation;
        private IPopcornPopper _popcornPopper;
        private IScreen _screen;
        public MovieTheaterFacade(IPcStation pcStation, IPopcornPopper popcornPopper, IScreen screen)
        {
            _pcStation = pcStation;
            _popcornPopper = popcornPopper;
            _screen = screen;
        }

        public void WatchMovie()
        {
            _pcStation.TurnOn();
            _pcStation.RecognizeMovieName();
            _pcStation.DownloadMovie();
        }
    }
}
