namespace DecoratorPatternExample
{
    // Decorators can execute their behavior either before or after the call to
    // a wrapped object.
    class Jeans : Decorator
    {
        public Jeans(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"{base.Operation()} + Jeans";
        }
    }
}
