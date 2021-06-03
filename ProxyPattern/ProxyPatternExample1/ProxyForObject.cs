using System;
namespace ProxyExample1
{
    public class ProxyForObject : ObjectInterface
    {
        private readonly ObjectThatDoesWork _worker;

        //Here you pass in the object that you want to represnet
        //This gives you access to the object
        public ProxyForObject(ObjectThatDoesWork worker)
        {
            _worker = worker;

        }

        public void DoWork()
        {
            Console.WriteLine("Proxy doing work");
            _worker.DoWork();
        }

        public void DoSomeOtherWork()
        {
            if (this.GiveAccess())
            {
                Console.WriteLine("Proxy giving access");
                Console.WriteLine("Proxy doing some other work");
                _worker.DoSomeOtherWork();
            }
        }

        //Proxy can add layer of protection 
        public bool GiveAccess()
        {
            return true;
        }
    }
}
