using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternExample
{
    public class BigTVRemote : AbstractionRemote
    {
        public BigTVRemote(ITV tv) : base(tv)
        {

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
