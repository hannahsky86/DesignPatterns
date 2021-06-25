using System;

namespace BridgePatternExample
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Big Remote \n");
            BigTVRemote bigTVRemote = new BigTVRemote(new BigTV());
            bigTVRemote.TurnOn();
            bigTVRemote.TurnOff();
            bigTVRemote.SetChannel(6);

            Console.WriteLine("\n Little Remote \n");
            LittleTVRemote littleTVRemote = new LittleTVRemote(new LittleTV());
            littleTVRemote.TurnOn();
            littleTVRemote.TurnOff();
            littleTVRemote.SetChannel(6);

            Console.WriteLine("\n Extended Special Remote \n");
            SpecialExtendedRemote extendedRemote = new SpecialExtendedRemote(new BigTV());
            extendedRemote.SpecialRemote();
            extendedRemote.TurnOn();
            extendedRemote.TurnOff();
            extendedRemote.SetChannel(6);

            Console.WriteLine("\n Can you use little remote with Big TV? \n");
            LittleTVRemote littleTVRemote1 = new LittleTVRemote(new BigTV());
            littleTVRemote1.TurnOn();
            littleTVRemote1.TurnOff();
            littleTVRemote1.SetChannel(6);

        }
    }

}
