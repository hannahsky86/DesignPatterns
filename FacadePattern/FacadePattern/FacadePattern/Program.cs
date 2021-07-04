namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Send the subsystems into the Facade to get only the things you need 
            Toolbox2 toolbox2 = new Toolbox2();
            Toolbox1 toolbox1 = new Toolbox1();
            Facade facade = new Facade(toolbox1, toolbox2);
            Client.ClientCode(facade);
        }
    }
}
