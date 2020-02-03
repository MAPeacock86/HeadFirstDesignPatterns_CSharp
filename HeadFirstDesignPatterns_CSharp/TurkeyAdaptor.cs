using Object_Adaptor.Duck;
using Object_Adaptor.Turkey;
using System;

namespace Object_Adaptor
{
    class TurkeyAdaptor : IDuck
    {
        private readonly ITurkey _turkey;

        internal TurkeyAdaptor(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            // Turkey's don't fly as far so we need 
            // to change the behavior a bit. 
            for(int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
