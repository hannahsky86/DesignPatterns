using System;

namespace DecoratorPatternExample
{
    public class Client
        {

            //The client sees all objects as components 
            public void ClientCode(Component component)
            {
                Console.WriteLine(component.Operation());
            }
        }
}
