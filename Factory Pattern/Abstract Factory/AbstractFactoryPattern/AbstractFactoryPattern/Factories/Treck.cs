namespace AbstractFactoryPattern
{
    //Brand - these factorys can create several different products
    class Treck : IAbstractBikeFactory
    {
        public IAbstractRoadBike CreateRoadBike()
        {
            return new TreckRoadBike1();
        }

        public IAbstractMountainBike CreateMountainBike()
        {
            return new TreckMountainBike1();
        }
    }
}
