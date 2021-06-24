using System;

namespace AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ThirdPartyTool thirdPartyTool = new ThirdPartyTool();
            ITarget target = new Adapter(thirdPartyTool);

            Console.WriteLine("The client can call the third party's tool with the adapter.");

            Console.WriteLine(target.DoSomeCoolThing());
        }
    }
}
