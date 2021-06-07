using System;

namespace ChainOfResponsibility
{

    public class Program
    {
        static void Main(string[] args)
        {
           
            var Fish = new FishHandler();
            var Bird = new BirdHandler();
            var FlyingFish = new FlyingFishHandler();
            Console.WriteLine("Test***");

            Console.WriteLine("Chain: Fish > Bird > Flying Fish");
            Fish.SetNext(Bird).SetNext(FlyingFish);
            Client.ClientCode(Fish);

            //var Amphibian = new Amphibian();
            //var Reptile = new Reptile();
            //var Mammal = new Mammal();
        }
    }

}
//public class Mammal { }



//Amphibians
//            Amphibians are vertebrates.
//Their skin is smooth and slimy.
//Amphibians breath through their skin, as well as their lungs in some cases.
//Amphibians are cold - blooded.
//They have a complex life cycle(larval and adult stages).
//Many species of amphibians vocalize.


//Reptiles
//            Reptiles Have Scales or Scutes.
//Reptiles Are Vertebrates. ...
//Reptiles Breathe Through Lungs. ...
//Reptiles Typically Have Four Legs. ...
//Reptiles Are Cold - Blooded(Ectohtermic)...
//Reptiles Are Oviparous(Egg Laying) Most reptiles reproduce sexually while others are capable of reproducing asexually. ...




//Mammals

//            The presence of hair or fur.
//Sweat glands.
//Glands specialized to produce milk, known as mammary glands.
//Three middle ear bones.
//A neocortex region in the brain, which specializes in seeing and hearing.
//Specialized teeth.
//A four-chambered heart.


