using System.Collections.Generic;
using System;

namespace myApp
{
    class BuildABikeUsingAScrewDriver : IStrategy
    {
        public BuildABikeUsingAScrewDriver()
        {
            Console.WriteLine("build a bike using a screw driver"); ;
        }

        public void BuildABike(object data)
        {
        }
    }
}
