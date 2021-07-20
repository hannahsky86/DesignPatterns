using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client bankCustomer = new Client();

            Console.WriteLine("Making a withdraw from the bank");
            Bank bank = new Bank();
            bankCustomer.ClientCode(bank);


            Console.WriteLine("Making a withdraw from the atm");
            ATM proxy = new ATM(bank);
            bankCustomer.ClientCode(proxy);
        }
    }
}
