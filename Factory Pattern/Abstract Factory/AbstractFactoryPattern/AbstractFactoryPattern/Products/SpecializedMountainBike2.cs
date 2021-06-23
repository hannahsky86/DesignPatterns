namespace AbstractFactoryPattern
{
    class SpecializedMountainBike2 : IAbstractMountainBike
    {
        public string GoUpAMountain()
        {
            return "My Specialized mountain bike wants to know - is the ride up worth the ride down?";
        }

        // The variant, Product B2, is only able to work correctly with the
        // variant, Product A2. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string RideOnTheRoad(IAbstractRoadBike collaborator)
        {
            var result = collaborator.RideOnTheRoad();

            return $"My Specialized mountain bike will compromise and ({result})";
        }
    }
}
