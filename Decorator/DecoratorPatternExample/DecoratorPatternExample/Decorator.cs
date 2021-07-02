namespace DecoratorPatternExample
{
   
    abstract class Decorator : Component
        {
            //Store the basic component
            protected Component _component;

            public Decorator(Component component)
            {
                this._component = component;
            }


            public override string Operation()
            {
                if (this._component != null)
                {
                    //if the component exists then call the operation on the componenet
                    return this._component.Operation();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
}
