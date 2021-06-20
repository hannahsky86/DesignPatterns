/*
 Factory and abstract factory

Object creation logic sometimes becomes complicated and constructor is not very discriptive

Factory: a component responsible solely for the wholesale creation of objects.


How to work with async invocation can not happen in the constructor
So how do you get asyn intialization?

Use a factory method and call the factory method 

 */

namespace FactoryPattern
{
    public class Demo
    {
        //public static async void Main(string[] args)
        //{
        //    var foo = new Foo();
        //    await foo.InitAsync();
        //}

        //Something better to do would be to use a factory method 
        //and make the constructor private
        //Example of async initialization
        public static async void Main(string[] args)
        {
           Foo x = await Foo.CreateAsync();
        }
    }
}
