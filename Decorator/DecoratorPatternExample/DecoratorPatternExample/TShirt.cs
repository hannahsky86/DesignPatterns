namespace DecoratorPatternExample
{
 
    class TShirt : Decorator
        {
            public TShirt(Component comp) : base(comp)
            {
            }

            public override string Operation()
            {
                return $"{base.Operation()} + Tshirt";
            }
        }
}
