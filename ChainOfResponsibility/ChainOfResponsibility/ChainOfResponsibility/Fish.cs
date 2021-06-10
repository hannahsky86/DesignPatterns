using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class FishHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            
            List<string> characteristics = new List<string> {
                "have cold blooded",
                "live in water",
                "have gills to breathe",
                "have swim bladders",
                "have fins for movement"
            };


            if (characteristics.Contains(request.ToString()))
            {
                return $"Fish: I {request}\n";
            }
            else
            {
                return base.Handle(request);
            }

        }
    }
}