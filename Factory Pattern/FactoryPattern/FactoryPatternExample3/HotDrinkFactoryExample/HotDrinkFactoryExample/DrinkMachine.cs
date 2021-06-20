using System;
using System.Collections.Generic;

namespace HotDrinkFactoryExample
{
 public class DrinkMachine
        {

            private List<Tuple<string, DrinkFactory>> factories =
                new List<Tuple<string, DrinkFactory>>();

            public DrinkMachine()
            {
                foreach (var t in typeof(DrinkMachine).Assembly.GetTypes())
                {
                    if (typeof(DrinkFactory).IsAssignableFrom(t) &&
                        !t.IsInterface)
                    {
                        factories.Add(Tuple.Create(
                            t.Name.Replace("Factory", string.Empty),
                            (DrinkFactory)Activator.CreateInstance(t)
                            ));
                    }
                }
            }
            public Drink MakeDrink()
            {
                Console.WriteLine("Available drinks:");
                for (var index = 0; index < factories.Count; index++)
                {
                    var tuple = factories[index];
                    Console.WriteLine($"{index} : {tuple.Item1}");
                }

                while (true)
                {
                    string s;
                    if ((s = Console.ReadLine()) != null
                        && int.TryParse(s, out int i)
                        && i >= 0
                        && i < factories.Count)
                    {
                        Console.WriteLine("Specify amount:");
                        s = Console.ReadLine();
                        if (s != null
                            && int.TryParse(s, out int amount)
                            && amount > 0)
                        {
                            return factories[i].Item2.Prepare(amount);
                        }
                    }
                    Console.WriteLine("Incorrect Input, try again.");
                }
            }
        }
    }
