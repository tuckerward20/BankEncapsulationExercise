using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myAccount = new BankAccount();
            myAccount.Deposit(25);
            myAccount.GetBalance();
        }
    }
}
