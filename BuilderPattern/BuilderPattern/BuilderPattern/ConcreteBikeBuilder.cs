namespace BuilderPattern
{
    //Concrete build class
    //implements build methods
    public class ConcreteBikeBuilder : IBikeBuilder
        {
           

            private Bike _bike = new Bike();

            //Create empty product object
            public ConcreteBikeBuilder()
            {
                this.Reset();
            }

            public void Reset()
            {
                this._bike = new Bike();
            }

            // All production steps work with the same product instance.
            public void BuildTire()
            {
                this._bike.Add("BuildTire");
            }

            public void BuildSeat()
            {
                this._bike.Add("BuildSeat");
            }

            public void BuildFrame()
            {
                this._bike.Add("BuildFrame");
            }

            
            //Reset builder so you can build another bike
            public Bike GetProduct()
            {
                Bike result = this._bike;

                this.Reset();

                return result;
            }
        }
    }

