using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyweightPattern
{
    //The FlyweightFactory manages the flyweight objects. It only creates a new one after it has
    //searched for an existing flyweight.
    //https://refactoring.guru/design-patterns/flyweight/csharp/example
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweightList = new List<Tuple<Flyweight, string>>();

        //Pass in the flyweight objects
        public FlyweightFactory(params Bike[] bikes)
        {
            foreach (var bike in bikes)
            {
                Flyweight flyweight = new Flyweight(bike);
                string flyweightKey = this.CreateKey(bike);
                Tuple<Flyweight, string>  flyweightAndKey = new Tuple<Flyweight, string>(flyweight, flyweightKey);
                flyweightList.Add(flyweightAndKey);
            }
        }

        // Returns a Flyweight's string hash for a given state.
        public string CreateKey(Bike bike)
        {
            List<string> elements = new List<string>();
            
            
            elements.Add(bike.Brand);
            elements.Add(bike.Color);
            elements.Add(bike.Gender);
            elements.Add(bike.Size);
            elements.Add(bike.Type);

            //if (bike.Rider != null && bike.SerialNumber != null)
            //{
            //    elements.Add(bike.Rider);
            //    elements.Add(bike.SerialNumber);
            //}

            elements.Sort();

            return string.Join("_", elements);
        }

        // Returns an existing Flyweight with a given state or creates a new
        // one.
        public Flyweight GetFlyweight(Bike sharedState)
        {
            //Create key of shared state
            string key = this.CreateKey(sharedState);
            Flyweight newFlyweight;

            foreach (var flyweight in flyweightList)
            {
                string fKey = flyweight.Item2;
                if (fKey == key)
                {
                    Console.WriteLine("This flyweight exists. Use the one already created.");
                    return flyweight.Item1;
                }
            }

            Console.WriteLine("This flyweight does not exist. Create a new one. ");
            newFlyweight = new Flyweight(sharedState);
            Tuple<Flyweight, string> flyweightAndKey = new Tuple<Flyweight, string>(newFlyweight, key);
            this.flyweightList.Add(flyweightAndKey);
            return newFlyweight;
        }

        public void listFlyweights()
        {
            Console.WriteLine("My Flyweight List \n");
            foreach (var flyweight in flyweightList)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}
