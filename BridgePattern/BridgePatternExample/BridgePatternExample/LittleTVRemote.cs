namespace BridgePatternExample
{
    class LittleTVRemote : AbstractionRemote
    {

        public LittleTVRemote(ITV tv) : base(tv)
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
