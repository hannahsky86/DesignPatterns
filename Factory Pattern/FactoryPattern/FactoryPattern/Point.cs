using System;


/*
 Factory and abstract factory

Object creation logic sometimes becomes complicated and constructor is not very discriptive

Factory: a component responsible solely for the wholesale creation of objects.


 */

namespace FactoryPattern
{
    public class Point
    {
        
        //This is the factory. 
        //It returns the constructor
        //Public static method - factory method design pattern 
        public static Point NewCartesianPoint(int x, int y)
        {
            Console.WriteLine($"{x}   {y}");
            return new Point(x, y);
        }

        //This lets the api understand how to use the parameters
        public static Point NewPolarPoint(double a, double b)
        {
            Console.WriteLine($"{a * Math.Cos(b)}   {a * Math.Sin(b)}");
            return new Point(a*Math.Cos(b), a*Math.Sin(b));
        }

        private double x, y;

        //Private constructor
        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
