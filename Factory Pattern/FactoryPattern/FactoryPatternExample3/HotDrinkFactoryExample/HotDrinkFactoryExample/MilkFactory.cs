using System;

namespace HotDrinkFactoryExample
{
    internal class MilkFactory : DrinkFactory
    {
        public Drink Prepare(int amount)
        {
            Console.WriteLine("Milk a cow");
            return new Milk();
        }
    }
}
