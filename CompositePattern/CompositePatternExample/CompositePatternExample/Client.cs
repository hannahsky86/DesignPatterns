using System;

namespace CompositePatternExample
{
    class Client
    {
        // The client code works with all of the components via the base
        // interface.
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"{leaf.Operation()}\n");
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2, "");
            }

            Console.WriteLine($"{component1.Operation()}");
        }
    }
}
