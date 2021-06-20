namespace HotDrinkFactoryExample
{

    class Program
    {
        static void Main(string[] args)
        {
            var machine = new DrinkMachine();
            var drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
