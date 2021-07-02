namespace DecoratorPatternExample
{
   //This is the basic thing that the decorators can add to.
   // it is abstract so you can overwrite it. 
    public abstract class Component
    {
        public abstract string Operation();
    }
}
