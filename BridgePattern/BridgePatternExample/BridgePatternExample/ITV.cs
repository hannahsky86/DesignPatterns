namespace BridgePatternExample
{
    //Implementation
    //Implementation classes need to inherit this interface
    public interface ITV
    {
        void TurnOnTV();
        void TurnOffTV();
        void SetChannel(int channel);
    }
}
