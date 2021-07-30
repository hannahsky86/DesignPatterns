using System;

namespace TemplateMethodExample
{
    // Usually, concrete classes override only a fraction of base class'
    // operations.
    class HanzoBike : BikeTemplateClass
    {
        protected override void AttachTheTires()
        {
            Console.WriteLine("Attach the tires.");
        }

        protected override void PumpTheTires()
        {
            Console.WriteLine("Pump the tires.");
        }

        protected override void DecorateWithLogo()
        {
            Console.WriteLine("Put my Hanzo logo on the tire.");
        }
    }
}
