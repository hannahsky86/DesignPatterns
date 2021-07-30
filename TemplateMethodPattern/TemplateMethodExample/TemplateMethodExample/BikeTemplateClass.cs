using System;

namespace TemplateMethodExample
{
    
    // This is the Abstract class
    // It defines the template method
    // The template method contains methods that outline an algorithm
    // subclasses override the abstract methods
    abstract class BikeTemplateClass
    {
        //The bike template lists methods for how to construct a bike 
        public void BikeTemplate()
        {
            this.BuildTheFrame();
            this.AttachTheTires();
            this.AttachTheHandleBar();
            this.DecorateWithLogo();
            this.PumpTheTires();
            this.AttachTheBikePedals();
            this.TuneTheBike();
        }

     
        protected void BuildTheFrame()
        {
            Console.WriteLine("Build the frame");
        }

        protected void AttachTheHandleBar()
        {
            Console.WriteLine("Attach the handle bars");
        }

        protected void AttachTheBikePedals()
        {
            Console.WriteLine("Attach the bike pedals");
        }


        //The subclasses must do these actions        
        protected abstract void AttachTheTires();

        protected abstract void PumpTheTires();


        //Protected virtual means that it is optional for the subclass to implement these
        //These are called "Hooks"
        protected virtual void DecorateWithLogo() { }

        protected virtual void TuneTheBike() { }
    }
}
