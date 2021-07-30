using System;

namespace TemplateMethodExample
{

    class GenericBike : BikeTemplateClass
    {
        protected override void AttachTheTires()
        {
            Console.WriteLine("Attach the tires.");
        }

        protected override void PumpTheTires()
        {
            Console.WriteLine("Pump the tires.");
        }
    }
}
