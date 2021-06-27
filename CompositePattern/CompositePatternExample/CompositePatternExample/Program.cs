using System;

namespace CompositePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);
            Console.WriteLine("\n");

            Composite body = new Composite();
            Composite heart = new Composite();
            Composite rightAtrium = new Composite();
            Composite leftAtrium = new Composite();
            rightAtrium.Add(new Leaf(), "RA leaf");
            leftAtrium.Add(new Leaf(), "LA leaf");
            heart.Add(rightAtrium, "RA");
            heart.Add(leftAtrium, "LA");
            Composite liver = new Composite();
            liver.Add(new Leaf(), "Liver leaf");
            liver.Add(new Leaf(), "Liver leaf");
            Composite lungs = new Composite();
            lungs.Add(new Leaf(), "Lungs leaf");
            lungs.Add(new Leaf(), "Lungs leaf");
            body.Add(heart, "heart");
            body.Add(liver, "liver");
            body.Add(lungs, "lungs");
            Console.WriteLine("The composite body is finished.");
            client.ClientCode(body);
            Console.WriteLine("\n");

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(body, leaf);
        }
    }
}
