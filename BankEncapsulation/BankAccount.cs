using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public BankAccount()
        {
        }

        public void Deposit(double deposit)
        {
            balance += deposit;
        }
        public void Withdrawt(double withdrawal)
        {
            balance -= withdrawal;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Your balance is {balance}");
        }
    }
}
