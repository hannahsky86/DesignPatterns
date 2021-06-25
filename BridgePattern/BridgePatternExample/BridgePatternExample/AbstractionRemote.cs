namespace BridgePatternExample
{
    
    //Interface for the two types of remotes
    public abstract class AbstractionRemote
    {
        protected ITV tv;

        protected AbstractionRemote(ITV tv)
        {
            this.tv = tv;
        }

        public abstract void SetChannel(int channelNumber);
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
