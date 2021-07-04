namespace FacadePattern
{
    //Sends client requests to the right object in the subsystem 
    //Creates a simple interface 
    public class Facade
        {
            protected Toolbox1 _toolbox1;

            protected Toolbox2 _toolbox2;

            public Facade(Toolbox1 subsystem1, Toolbox2 subsystem2)
            {
                this._toolbox1 = subsystem1;
                this._toolbox2 = subsystem2;
            }

            //this is where the facade provides access to the subsystem's methods
            public string Operation()
            {
                string result = "Facade initializes subsystems:\n";
                result += this._toolbox2.Drill();
                result += this._toolbox1.Hammer();
                result += "Facade orders subsystems to perform the action:\n";
                result += this._toolbox2.Level();
                result += this._toolbox1.ScrewDriver();
                return result;
            }
        }
    }
