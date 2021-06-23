using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new Treck());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new Specialized());
        }

        public void ClientMethod(IAbstractBikeFactory factory)
        {
            var roadBike = factory.CreateRoadBike();
            var mountainBike = factory.CreateMountainBike();

            Console.WriteLine(mountainBike.GoUpAMountain());
            Console.WriteLine(mountainBike.RideOnTheRoad(roadBike));
            Console.WriteLine(roadBike.RideOnTheRoad());
        }
    }
}
