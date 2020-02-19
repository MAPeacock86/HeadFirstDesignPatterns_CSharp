using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheaterComponents
{
    class TheaterLights
    {

        internal void Dim(int brightness)
        {
            Console.WriteLine($"Dimming theater lights to {brightness}");
        }

        internal void On()
        {
            Console.WriteLine($"Turning lights on bright");
        }
    }
}
