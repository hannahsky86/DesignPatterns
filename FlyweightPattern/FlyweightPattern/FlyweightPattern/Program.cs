using System;
// Use Json.NET library, you can download it from NuGet Package Manager

//https://refactoring.guru/design-patterns/flyweight/csharp/example

namespace FlyweightPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike { SerialNumber = "1", Brand = "Specialized", Color="black", Gender="F", Rider="Hannah", Size="50", Type="Road"};
            Bike bike2 = new Bike { SerialNumber = "2", Brand = "Treck", Color = "red", Gender = "F", Rider = "Hannah", Size = "50", Type = "Mountain" };
            Bike bike3 = new Bike { SerialNumber = "3", Brand = "Felt", Color = "blue", Gender = "M", Rider = "Alex", Size = "60", Type = "Road" };
            Bike bike4 = new Bike { SerialNumber = "4", Brand = "Scott", Color = "black", Gender = "F", Rider = "Jill", Size = "53", Type = "Mountain" };
            Bike bike5 = new Bike { SerialNumber = "5", Brand = "Fuji", Color = "red", Gender = "M", Rider = "Mark", Size = "55", Type = "Mountain" };



            // The client code usually creates a bunch of pre-populated
            // flyweights in the initialization stage of the application.
            var factory = new FlyweightFactory( bike1, bike2, bike3, bike4, bike5);

            factory.listFlyweights();

            AddToFlyweightList(factory, new Bike { SerialNumber = "6", Brand = "Fuji", Color = "green", Gender = "M", Rider = "Mark", Size = "55", Type = "Mountain" });

            AddToFlyweightList(factory, new Bike { SerialNumber = "7", Brand = "Fuji", Color = "green", Gender = "M", Rider = "Mark", Size = "55", Type = "Mountain" });

            factory.listFlyweights();
        }

        public static void AddToFlyweightList(FlyweightFactory factory, Bike bike)
        {
            Console.WriteLine("Add bike to the flyweight factory:");


            var flyweight = factory.GetFlyweight(new Bike
            {
                Brand = bike.Brand,
                Color = bike.Color,
                Gender = bike.Gender,
                Size = bike.Size,
                Type = bike.Type
            });

  
            // The client code either stores or calculates extrinsic state and
            // passes it to the flyweight's methods.
            flyweight.DisplayUniqueAndSharedAttributes(bike);
        }
    }
}
