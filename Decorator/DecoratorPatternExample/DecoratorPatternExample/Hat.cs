namespace DecoratorPatternExample
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    class Hat : Decorator
    {
        public Hat(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"{base.Operation()} + Hat";
        }
    }
}
