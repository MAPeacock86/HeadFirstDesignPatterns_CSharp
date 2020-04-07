using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheaterComponents
{
    internal class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("Popcorn Popper On");
        }
        
        internal void Pop()
        {
            Console.WriteLine("Popcorn popping");
        }

        internal void Off()
        {
            Console.WriteLine("Popcorn Popper Off");
        }

    }
}
