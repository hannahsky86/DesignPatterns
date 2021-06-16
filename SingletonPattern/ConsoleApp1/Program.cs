using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike b1 = Bike.MyBike();
            Bike b2 = Bike.MyBike();

            if (b1 == b2)
            {
                Console.WriteLine("It is the same bike");
            }
            else
            {
                Console.WriteLine("Not the same bike.");
            }

            Bike.CanTheyBorrowYourBike();
           
        }
    }
}