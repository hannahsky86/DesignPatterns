﻿namespace AbstractFactoryPattern
{
    // Concrete Products are created by corresponding Concrete Factories.
    class TreckMountainBike1 : IAbstractMountainBike
    {
        public string GoUpAMountain()
        {
            return "My Treck mountain bike wants to know - is the ride up worth the ride down?";
        }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string RideOnTheRoad(IAbstractRoadBike collaborator)
        {
            var result = collaborator.RideOnTheRoad();

            return $"My Treck mountain bike will compromise and ({result})";
        }
    }
}
