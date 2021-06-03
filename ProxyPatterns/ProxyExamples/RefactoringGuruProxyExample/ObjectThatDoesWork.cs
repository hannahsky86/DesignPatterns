using System;
namespace ProxyExample1
{
    public class ObjectThatDoesWork : ObjectInterface
    {
        public void DoWork()
        {
            Console.WriteLine("Object doing work");
        }

        public void DoSomeOtherWork()
        {
            Console.WriteLine("Object doing some other work");
        }
    }
}
