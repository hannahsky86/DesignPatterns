using System;

namespace FacadePattern
{
    class Client
    {
 
        //The client might not even know about the subsystems, since it only works with the facade 
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }

}
