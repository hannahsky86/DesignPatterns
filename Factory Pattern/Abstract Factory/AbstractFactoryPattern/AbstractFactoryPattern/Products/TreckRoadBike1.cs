namespace AbstractFactoryPattern
{
    // Concrete Products are created by corresponding Concrete Factories.
    class TreckRoadBike1 : IAbstractRoadBike
    {
        public string RideOnTheRoad()
        {
            return "ride on the road";
        }
    }
}
