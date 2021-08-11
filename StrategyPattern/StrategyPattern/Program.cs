using System;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var decisionMaker = new DecisionMaker();

            decisionMaker.SetStrategy(new BuildABikeUsingAHammer());
            decisionMaker.DoMoreWork();

            Console.WriteLine();

            decisionMaker.SetStrategy(new BuildABikeUsingAScrewDriver());
            decisionMaker.DoMoreWork();
        }
    }
}
