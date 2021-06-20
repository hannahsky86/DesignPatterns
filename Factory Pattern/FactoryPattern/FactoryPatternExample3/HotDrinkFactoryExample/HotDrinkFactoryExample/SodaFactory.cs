using System;

namespace HotDrinkFactoryExample
{
    internal class SodaFactory: DrinkFactory
    {
        public Drink Prepare(int amount)
        {
            Console.WriteLine("Put in the bubbles");
            return new Soda();
        }
    }
}
