namespace DecoratorPatternExample
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    class Scarf : Decorator
    {
        public Scarf(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"{base.Operation()} + Scarf";
        }
    }
}
