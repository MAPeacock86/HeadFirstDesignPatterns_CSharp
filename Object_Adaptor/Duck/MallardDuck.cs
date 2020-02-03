using System;

namespace Object_Adaptor.Duck
{
    class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
