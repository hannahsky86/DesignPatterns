using System;

using System;
using System.Collections.Generic;

namespace BuilderPattern
{


       
        //Builder interface outlines build methods
        public interface IBikeBuilder
        {
            void BuildTire();

            void BuildSeat();

            void BuildFrame();
        }

       
        //Concrete build class
        //implements build methods
        public class ConcreteBikeBuilder : IBikeBuilder
        {
           

            private Bike _bike = new Bike();

            //Create empty product object
            public ConcreteBikeBuilder()
            {
                this.Reset();
            }

            public void Reset()
            {
                this._bike = new Bike();
            }

            // All production steps work with the same product instance.
            public void BuildTire()
            {
                this._bike.Add("BuildTire");
            }

            public void BuildSeat()
            {
                this._bike.Add("BuildSeat");
            }

            public void BuildFrame()
            {
                this._bike.Add("BuildFrame");
            }

            
            //Reset builder so you can build another bike
            public Bike GetProduct()
            {
                Bike result = this._bike;

                this.Reset();

                return result;
            }
        }

        // It makes sense to use the Builder pattern only when your products are
        // quite complex and require extensive configuration.
        //
        // Unlike in other creational patterns, different concrete builders can
        // produce unrelated products. In other words, results of various builders
        // may not always follow the same interface.
        public class Bike
        {
            private List<object> _parts = new List<object>();

            public void Add(string part)
            {
                this._parts.Add(part);
            }

            public string ListParts()
            {
                string str = string.Empty;

                for (int i = 0; i < this._parts.Count; i++)
                {
                    str += this._parts[i] + ", ";
                }

                str = str.Remove(str.Length - 2); // removing last ",c"

                return "Product parts: " + str + "\n";
            }
        }

        //Builder boss directs the build process 
        public class BikeBuilderBoss
        {
            private IBikeBuilder _builder;

            public IBikeBuilder Builder
            {
                set { _builder = value; }
            }

            public void BuildBasicModel()
            {
                this._builder.BuildFrame();
            }

            public void BuildEntireBike()
            {
                this._builder.BuildFrame();
                this._builder.BuildSeat();
                this._builder.BuildTire();
            }
        }

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

