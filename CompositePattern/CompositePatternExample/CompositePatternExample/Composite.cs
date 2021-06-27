using System;
using System.Collections.Generic;

namespace CompositePatternExample
{

    // composite usually delegate work to children and sup up results
    class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component, string name)
        {
            Console.WriteLine($"Add: {name}");
            this._children.Add(component);
        }

        public override void Remove(Component component, string name)
        {
            Console.WriteLine($"Remove: {name}");
            this._children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += $"+";
                }
                i++;
            }

            return result + ")";
        }
    }
}
