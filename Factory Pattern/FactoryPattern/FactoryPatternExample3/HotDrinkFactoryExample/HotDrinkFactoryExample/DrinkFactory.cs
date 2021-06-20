namespace HotDrinkFactoryExample
{
    //Instead of making one drink factory, you can make an interface.
    //This factory needs to be able to prepare the drink and return it.
    //So return type is IDrink and 
    public interface DrinkFactory
    {
        Drink Prepare(int amount);
    }
}
