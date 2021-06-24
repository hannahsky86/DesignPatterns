namespace BuilderPattern
{
    //Builder boss directs the build process 
    public class BikeBuilderBoss
        {
            private IBikeBuilder _builder;

            public IBikeBuilder Builder
            {
                set { _builder = value; }
            }

            public void BuildBasicModel()
            {
                this._builder.BuildFrame();
            }

            public void BuildEntireBike()
            {
                this._builder.BuildFrame();
                this._builder.BuildSeat();
                this._builder.BuildTire();
            }
        }
    }

