namespace ConsoleApp1
{
    public class Client
    {
        //Pass in the interface so you can work with the bank or atm
        public void ClientCode(IBankServices financialObject)
        {
            financialObject.Withdraw();
        }
    }
}
