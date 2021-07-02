using System;

namespace DecoratorPatternExample
{

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            //The client is incharge of organizing the components 

            var item = new GenericComponent();
            Console.WriteLine("This is a generic component");
            client.ClientCode(item);
            Console.WriteLine();

            Body body = new Body();
            TShirt bodyWithTShirt = new TShirt(body);
            Jeans bodyWithTShirtAndJeans = new Jeans(bodyWithTShirt);
            Hat bodyWithTShirtAndJeansAndHat = new Hat(bodyWithTShirtAndJeans);
            Scarf bodyWithTShirtAndJeansAndHatAndScarf = new Scarf(bodyWithTShirtAndJeansAndHat);
            Console.WriteLine("Now I'm dressed!");
            client.ClientCode(bodyWithTShirtAndJeansAndHatAndScarf);
        }
    }
}
