using System;


/*
 Factory and abstract factory

Object creation logic sometimes becomes complicated and constructor is not very discriptive

Factory: a component responsible solely for the wholesale creation of objects.


How to work with async invocation can not happen in the constructor
So how do you get asyn intialization?

Use a factory method and call the factory method 

 */

namespace FactoryPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            var polarPoint = Point.NewPolarPoint(1.2, 3.4);
            Console.WriteLine(polarPoint);

            var cartPoint = Point.NewCartesianPoint(4, 6);
            Console.WriteLine(cartPoint);

        }
    }
}
