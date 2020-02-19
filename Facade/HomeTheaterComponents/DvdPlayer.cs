using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheaterComponents
{
    class DvdPlayer
    {
        internal void On()
        {
            Console.WriteLine("Turning on the dvd player");
        }

        internal void Play(string movie)
        {
            Console.WriteLine($"Starting the movie:{movie}");
        }

        internal void Stop()
        {
            Console.WriteLine("Stopping the movie");
        }

        internal void Eject()
        {
            Console.WriteLine($"Ejecting the movie");
        }

        internal void Off()
        {
            Console.WriteLine($"Turning off the dvd player");
        }
    }
}
