namespace ProxyExample1
{
    public class MyClient
    {
        // This lets you pass in anything that implements the objectInterface
        // You can call any specific method in the object
        // Do not need to instantiate the whole object
        public void DoSomeClientWork(ObjectInterface objectInterface)
        {
            objectInterface.DoWork();
        }
        public void DoSomeOtherWork(ObjectInterface objectInterface)
        {
            objectInterface.DoSomeOtherWork();
        }
    }
}
