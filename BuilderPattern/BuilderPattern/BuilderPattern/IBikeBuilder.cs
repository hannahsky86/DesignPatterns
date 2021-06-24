namespace BuilderPattern
{
    //Builder interface outlines build methods
    public interface IBikeBuilder
        {
            void BuildTire();

            void BuildSeat();

            void BuildFrame();
        }
    }

