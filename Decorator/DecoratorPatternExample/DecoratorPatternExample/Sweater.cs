namespace DecoratorPatternExample
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    class Sweater : Decorator
    {
        public Sweater(Component comp) : base(comp)
        {

        }
        public override string Operation()
        {
            return $"{base.Operation()} + Sweater";
        }
    }
}
