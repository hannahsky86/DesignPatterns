using System;

namespace FactoryPatternExample2
{

    //instead of having a lot of factory methods inside the point
    //create a point factory and have the methods there 
    public static class PointFactory
    {
        //Then move the factory methods here
        public static Point1 NewCartesianPoint(double a, double b)
        {
            return new Point1(a, b);
        }
        public static Point1 NewPolarPoint(double rho, double theta)
        {
            return new Point1(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        //if you want to have an external component, you need to make the 
        //constructor public
    }
    
    public class Point1
    {
        private double x, y;
        public Point1(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    //If you want the point to be private, you need to make the factory an internal
    //class of point.
    //Then to call the point factory, you call Point.PointFactory. You can do this
    //because the factory is static and all of its members are static
    //If you do not want the internal factory class to be static, then make 
    //an internal public static PointFactory property
    //public static PointFactory Factory => new PointFactory(); 
    //Then you can remove static on the PointFactory class and PointFactory methods
    //Do this if you want to instantiate a factory explicitly


    class Program
    {
        static void Main(string[] args)
        {
            var p = new Point1(1,3);
            var pointCart = PointFactory.NewCartesianPoint(1.0, Math.PI / 2);
            var pointPolar = PointFactory.NewPolarPoint(1, 2);
            Console.WriteLine(pointCart);
            Console.WriteLine(pointPolar);
        }
    }
}
