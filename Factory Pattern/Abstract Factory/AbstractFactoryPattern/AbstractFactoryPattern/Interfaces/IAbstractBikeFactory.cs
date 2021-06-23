namespace AbstractFactoryPattern
{
    //This declares methods that return abstract products
    public interface IAbstractBikeFactory
    {
        IAbstractRoadBike CreateRoadBike();

        IAbstractMountainBike CreateMountainBike();
    }
}
