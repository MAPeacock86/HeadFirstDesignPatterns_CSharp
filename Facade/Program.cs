using Facade.HomeTheaterComponents;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize components 
            var popper = new PopcornPopper();
            var lights = new TheaterLights();
            var screen = new Screen();
            var projector = new Projector();
            var amp = new Amplifier();
            var dvd = new DvdPlayer();

            // Watch "Raiders of the Lost Ark"
            var movieTitle = "Raiders of the Lost Ark";
            Console.WriteLine($"Get ready to watch a movie...");
            popper.On();
            lights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amp.On();
            amp.setDvd(dvd);
            amp.SetSurroundSound();
            amp.SetVolume(5);
            dvd.On();
            dvd.Play(movieTitle);

            // End Movie
            Console.WriteLine("Shutting movie theater down");
            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amp.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();

        }
    }
}
