using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Client
    {
        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static void ClientCode(AbstractHandler handler)
        {
            List<string> Characteristics = new List<string> {
                 "have cold blooded",
                "live in water",
                "have feathers",
                "have wings",
                "have beaks",
                "lay eggs",
                "have a skeleton",
                "have gills to breathe",
                "have swim bladders",
                "have fins for movement",
                "am super cool"

            };

            foreach (var item in Characteristics)
            {
                var result = handler.Handle(item);

                if (result != null)
                {
                    Console.Write($" {result}");
                }
                else
                {
                    Console.WriteLine($" {item} was left untouched.");
                }
            }
        }
    }
}