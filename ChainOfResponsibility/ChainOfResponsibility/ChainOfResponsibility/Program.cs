using System;

namespace ChainOfResponsibility
{

    public class Program
    {
        static void Main(string[] args)
        {
           
            var Fish = new FishHandler();
            var Bird = new BirdHandler();
            var FlyingFish = new FlyingFishHandler();

            Console.WriteLine("Chain: Fish > Bird > Flying Fish");
            Fish.SetNext(Bird).SetNext(FlyingFish);
            Client.ClientCode(Fish);

        }
    }
}