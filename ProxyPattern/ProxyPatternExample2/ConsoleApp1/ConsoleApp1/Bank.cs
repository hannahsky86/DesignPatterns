using System;

namespace ConsoleApp1
{
   
    //This object might do work that takes a long time 
    //Going to a real bank is a lot of work 
    class Bank : IBankServices
    {
        public void Withdraw()
        {
            Console.WriteLine("This is the Bank - would you like to make a withdraw?");
        }
    }
}
