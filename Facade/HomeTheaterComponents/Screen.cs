using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheaterComponents
{
    class Screen
    {
        internal void Down()
        {
            Console.WriteLine("Lowering the screen");
        }

        internal void Up()
        {
            Console.WriteLine($"Raising the screen");
        }
    }
}
