using System;


namespace BuilderPattern
{
    class Program
        {
            static void Main(string[] args)
            {
                // The client code creates a builder object, passes it to the
                // director and then initiates the construction process. The end
                // result is retrieved from the builder object.
                var director = new BikeBuilderBoss();
                var builder = new ConcreteBikeBuilder();
                director.Builder = builder;

                //With director
                Console.WriteLine("Build basic bike:");
                director.BuildBasicModel();
                Console.WriteLine(builder.GetProduct().ListParts());

                Console.WriteLine("Build entire bike:");
                director.BuildEntireBike();
                Console.WriteLine(builder.GetProduct().ListParts());

                //Without director
                Console.WriteLine("Build youself a bike:");
                builder.BuildFrame();
                builder.BuildSeat();
                builder.BuildTire();
                Console.Write(builder.GetProduct().ListParts());
            }
        }
    }

