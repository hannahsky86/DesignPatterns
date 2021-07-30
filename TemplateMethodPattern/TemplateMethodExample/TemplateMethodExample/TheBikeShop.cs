namespace TemplateMethodExample
{
    class TheBikeShop
    {
        public static void BuildABike(BikeTemplateClass bikeTemplate)
        {
            //The client can just work with the interface of the base class.
            //It doesn't need to know about concrete classes 
            bikeTemplate.BikeTemplate();
        }
    }
}
