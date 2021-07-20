using System;

namespace ConsoleApp1
{
    //An ATM is like a Bank proxy
    //It serves a similar purpose if you are making a withdraw 
    class ATM : IBankServices
    {
        private Bank _bank;

        public ATM(Bank bank)
        {
            this._bank = bank;
        }

          
        public void Withdraw()
        {
            //The proxy can provide additional security and functionality 
            if (this.CheckAccess())
            {
                this._bank.Withdraw();

                this.ATMReceipt();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("ATM is checking that your information is valid.");

            return true;
        }

        public void ATMReceipt()
        {
            Console.WriteLine("ATM is printing your receipt.");
        }
    }
}
