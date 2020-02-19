using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheaterComponents
{
    class Projector
    {
        private DvdPlayer _dvdPlayer;

        internal void On()
        {
            Console.WriteLine("Turning on the projector");
        }

        internal void SetInput(DvdPlayer dvdPlayer)
        {
            _dvdPlayer = dvdPlayer;
        }

        internal void WideScreenMode()
        {
            Console.WriteLine("Setting wide screen mode");
        }

        internal void Off()
        {
            Console.WriteLine($"Turning off the projector");
        }
    }
}
