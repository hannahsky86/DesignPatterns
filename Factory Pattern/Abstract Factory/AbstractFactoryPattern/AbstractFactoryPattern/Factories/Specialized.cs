namespace AbstractFactoryPattern
{
    // Each Concrete Factory has a corresponding product variant.
    class Specialized : IAbstractBikeFactory
    {
        public IAbstractRoadBike CreateRoadBike()
        {
            return new SpecializedRoadBike2();
        }

        public IAbstractMountainBike CreateMountainBike()
        {
            return new SpecializedMountainBike2();
        }
    }
}
