using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class FlyingFishHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            List<string> characteristics = new List<string>
            {
            "have cold blooded",
                "live in water",
                "have feathers",
                "have wings",
                "have beaks",
                "lay eggs",
                "have a skeleton",
                "have gills to breathe",
                "have swim bladders",
                "have fins for movement",
                "am super cool"
            };


            if (characteristics.Contains(request.ToString()))
            {
                return $"Flying fish: I {request}\n";
            }
            else
            {
                return base.Handle(request);
            }

        }
    }
}





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


//Birds
//            Feathers.Feathers are the defining characteristic of Aves, found on every living species of bird and no other class of animal. ...
//Wings.All birds have wings, although not all birds fly. ...
//Beak.All birds have beaks, or bills, made of a bony core surrounded by a thin layer of keratin. ...
//Eggs. ...
//Skeleton.


//Mammals

//            The presence of hair or fur.
//Sweat glands.
//Glands specialized to produce milk, known as mammary glands.
//Three middle ear bones.
//A neocortex region in the brain, which specializes in seeing and hearing.
//Specialized teeth.
//A four-chambered heart.


