using System;
//https://refactoring.guru/design-patterns/prototype/csharp/example example 


namespace PrototypePatternExample1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrototypeBaby babyA = new PrototypeBaby();
            babyA.Dimentions = new Dimentions(22, 8);
            babyA.Name = "Chubster";
            babyA.eyeColor = "Brown";
            babyA.IdInfo = new IdInfo(1);

            //Shallow copy of babyA 
            PrototypeBaby babyB = babyA.ShallowCopy();

            //Deep copy of babyA
            PrototypeBaby babyC = babyA.DeepCopy();

            //DisplayValues 
            Console.WriteLine("Original values of babyA, babyB, and babyC");
            Console.WriteLine($"baby A {babyA.Dimentions.height} {babyA.Dimentions.weight} {babyA.Name}  {babyA.IdInfo.IdNumber}");
            Console.WriteLine($"baby B {babyB.Dimentions.height} {babyB.Dimentions.weight} {babyB.Name}  {babyB.IdInfo.IdNumber}");
            Console.WriteLine($"baby C {babyC.Dimentions.height} {babyC.Dimentions.weight} {babyC.Name}  {babyC.IdInfo.IdNumber}");

        }
    }
}