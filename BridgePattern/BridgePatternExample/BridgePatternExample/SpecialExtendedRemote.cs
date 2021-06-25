using System;

namespace BridgePatternExample
{
    public class SpecialExtendedRemote : AbstractionRemote
    {

        public SpecialExtendedRemote(ITV tv) : base(tv)
        {

        }

        public void SpecialRemote()
        {
            Console.WriteLine("I am special");
        }

        public override void SetChannel(int channelNumber)
        {
            tv.SetChannel(channelNumber);
        }

        public override void TurnOff()
        {
            tv.TurnOffTV();
        }

        public override void TurnOn()
        {
            tv.TurnOnTV();
        }
    }
}
