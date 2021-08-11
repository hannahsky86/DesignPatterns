using System.Collections.Generic;
using System;

namespace myApp
{
    //Implement strategy
    class BuildABikeUsingAHammer : IStrategy
    {
        public BuildABikeUsingAHammer()
        {
            Console.WriteLine("build a bike using a hammer");
        }

        public void BuildABike(object data)
        {
        }
    }
}
