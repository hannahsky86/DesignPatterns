using System;
namespace ProxyExample1
{
    public class ProxyExample
    {

        static void Main(string[] args)
        {

            // Example of calling the client without the proxy
            // you need to instantiate the whole object and
            // pass the whole object to the client 
            MyClient client1 = new MyClient();
            Console.WriteLine("Client: do work without proxy.");
            ObjectThatDoesWork worker = new ObjectThatDoesWork();
            client1.DoSomeClientWork(worker);
            client1.DoSomeOtherWork(worker);

            // Example of calling the client with the proxy
            // Here you do not need to instantiate the entire object
            // You just instantiate the proxy and pass it to the client
            // the client then does the work specified in the method 
            MyClient client2 = new MyClient();
            Console.WriteLine("Client: do work with the proxy");
            ProxyForObject proxy = new ProxyForObject(worker);
            client2.DoSomeClientWork(proxy);
            client2.DoSomeOtherWork(proxy);
        }
    }
}
                            