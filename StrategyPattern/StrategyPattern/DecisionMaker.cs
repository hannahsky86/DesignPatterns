using System;
using System.Collections.Generic;

namespace myApp
{
    class DecisionMaker
    {
        //Reference Strategy interface
        private IStrategy _strategy;

        public DecisionMaker(){ }

        public DecisionMaker(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoMoreWork()
        {
            Console.WriteLine("Work smarter not harder...");
        }
    }
}
