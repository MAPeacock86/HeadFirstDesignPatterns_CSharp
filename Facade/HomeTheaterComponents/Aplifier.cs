using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheaterComponents
{
    class Aplifier
    {
        private DvdPlayer _dvdPlayer;

        internal void setDvd(DvdPlayer dvdPlayer)
        {
            _dvdPlayer = dvdPlayer;
        }

        internal void SetSurroundSound()
        {
            Console.WriteLine("Turning on surround sound");
        }

        internal void SetVolume(int volume)
        {
            Console.WriteLine($"Setting the volume to {volume}");
        }

        internal void Off()
        {
            Console.WriteLine($"Turning off the amp");
        }

        internal void On()
        {
            Console.WriteLine($"Turning on the amp");
        }
    }
}
