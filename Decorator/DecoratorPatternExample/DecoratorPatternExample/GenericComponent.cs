namespace DecoratorPatternExample
{
   //This is a generic component 
   //It can be called directly 
    class GenericComponent : Component
    {
        public override string Operation()
        {
            return "This is a generic component";
        }
    }
}
