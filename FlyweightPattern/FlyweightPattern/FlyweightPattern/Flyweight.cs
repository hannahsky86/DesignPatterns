using System;
// Use Json.NET library, you can download it from NuGet Package Manager
using Newtonsoft.Json;


namespace FlyweightPattern
{
    //Stores the common state
    //Everything else is sent through the method parameters
    public class Flyweight
    {
        private Bike _sharedBikeAttributes;

        public Flyweight(Bike sharedBikeAttributes)
        {
            this._sharedBikeAttributes = sharedBikeAttributes;
        }

        public void DisplayUniqueAndSharedAttributes(Bike uniqueAttributes)
        {
            Console.WriteLine("Shared Attributes:");
            Console.WriteLine($"{ _sharedBikeAttributes.Type}");
            Console.WriteLine($"{ _sharedBikeAttributes.Brand}");
            Console.WriteLine($"{ _sharedBikeAttributes.Size}");
            Console.WriteLine($"{ _sharedBikeAttributes.Gender}");
            Console.WriteLine($"{ _sharedBikeAttributes.Color}");

            Console.WriteLine("Unique Attributes:");
            Console.WriteLine($"{ uniqueAttributes.SerialNumber}");
            Console.WriteLine($"{ uniqueAttributes.Rider}");


            //Rider,Type,Brand,Size, Gender, Color


        }
    }
}
