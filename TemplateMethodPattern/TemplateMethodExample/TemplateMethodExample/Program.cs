using System;

namespace TemplateMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            TheBikeShop.BuildABike(new GenericBike());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            TheBikeShop.BuildABike(new HanzoBike());
        }
    }
}
