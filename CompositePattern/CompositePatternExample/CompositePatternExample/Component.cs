using System;

namespace CompositePatternExample
{

    abstract class Component
    {
        public Component() { }

        //Can implement default behavior or force an overwrite with abstract. 
        public abstract string Operation();

        //Child management operation
        public virtual void Add(Component component, string name)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component, string name)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
