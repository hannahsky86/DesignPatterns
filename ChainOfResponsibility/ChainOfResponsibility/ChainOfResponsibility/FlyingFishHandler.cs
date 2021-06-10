using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class FlyingFishHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            List<string> characteristics = new List<string>
            {
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


            if (characteristics.Contains(request.ToString()))
            {
                return $"Flying fish: I {request}\n";
            }
            else
            {
                return base.Handle(request);
            }

        }
    }
}

