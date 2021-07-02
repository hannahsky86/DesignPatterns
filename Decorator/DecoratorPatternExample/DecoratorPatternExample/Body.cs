namespace DecoratorPatternExample
{
    //This is the basic component
    class Body : Component
    {
        //This object's job is to say "This is my birthday suit"
        public override string Operation()
        {
            return "Birthday suit";
        }
    }
}
