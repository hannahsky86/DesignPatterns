using System;

namespace HotDrinkFactoryExample
{
    //No factory will return soda or milk, they will all return the 
    //Drink interface. 
    internal class Milk : Drink
    {
        public void Consume()
        {
            Console.WriteLine("This milk is fresh");
        }
    }
}
