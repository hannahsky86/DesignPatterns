using System;

namespace BridgePatternExample
{
    public class LittleTV : ITV
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Set Channel on little TV");
        }

        public void TurnOffTV()
        {
            Console.WriteLine("Turn off little TV");
        }

        public void TurnOnTV()
        {
            Console.WriteLine("Turn on little TV");
        }
    }

}
