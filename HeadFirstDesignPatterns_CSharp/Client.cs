using Object_Adaptor.Duck;
using Object_Adaptor.Turkey;
using System;

namespace Object_Adaptor
{
    class Client
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();
            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdaptor(turkey);

            Console.WriteLine("The turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe duck says...");
            testDuck(duck);

            Console.WriteLine("\nThe turkey adaptor says...");
            testDuck(turkeyAdapter);
        }

        private static void testDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
