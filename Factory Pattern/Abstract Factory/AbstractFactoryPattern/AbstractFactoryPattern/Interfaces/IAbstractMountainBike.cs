namespace AbstractFactoryPattern
{
    // Base interface of another product.
    // Only products of the same brand can interact with eachother. 
    public interface IAbstractMountainBike
    {
        string GoUpAMountain();

        //Can interact with another product of the same brand
        string RideOnTheRoad(IAbstractRoadBike collaborator);
    }
}
