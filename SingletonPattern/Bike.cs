using System;

namespace SingletonExample
{
    class Bike
    {
        private static Bike _myBike;


        private Bike()
        {

        }

        public static Bike MyBike()
        {
            if (_myBike == null)
            {
                _myBike = new Bike();
            }

            return _myBike;
        }

        public static void CanTheyBorrowYourBike()
        {
            Console.WriteLine("Are a friend?");
            string answer = Console.ReadLine();
            if (answer.Equals("Yes"))
            {
                Console.WriteLine("Sure, you can borrow my bike!");
            }
            else
            {
                Console.WriteLine("No, you can not borrow my bike.");
            }
        }
    }
}
