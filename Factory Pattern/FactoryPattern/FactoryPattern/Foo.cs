using System.Threading.Tasks;


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
    public class Foo
    {

        ////Can not do await in the constructor 
        //public Foo()
        //{

        //}

        ////create and initialization method
        ////This makes the use of the class complicated because you have to 
        ////invoke the constructor and remember to call InitAsync
        //public async Task<Foo> InitAsync()
        //{
        //    await Task.Delay(1000);
        //    return this;
        //}

        //Make the constructor private
        private Foo()
        {
            //
        }

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        public static Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return result.InitAsync();
        }

    }
}
