using System;

namespace BridgePatternExample
{
    public class BigTV : ITV
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Set Channel on big TV");
        }

        public void TurnOffTV()
        {
            Console.WriteLine("Turn channel off");
        }

        public void TurnOnTV()
        {
            Console.WriteLine("Turn channel on");
        }
    }

}
