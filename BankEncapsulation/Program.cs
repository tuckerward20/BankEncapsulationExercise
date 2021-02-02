using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to the ATM. What would you like to do?");
        string answer = Console.ReadLine();
        answer.ToLower();
        var myAccount = new BankAccount();
        myAccount.Deposit(25);
        myAccount.GetBalance();
        bool loop = true;
        while (loop == true)
        {
            switch (answer)
            {
                case "deposit":
                    Console.WriteLine("How much would you like to deposit?");
                    double amount;
                    amount = Convert.ToDouble(Console.ReadLine());
                    myAccount.Deposit(amount);
                    Console.WriteLine("What else would you like to do?");
                    answer = Console.ReadLine();
                    break;
                case "withdraw":
                    Console.WriteLine("How much would you like to withdraw?");
                    amount = Convert.ToDouble(Console.ReadLine());
                    myAccount.Deposit(amount);
                    Console.WriteLine("What else would you like to do?");
                    answer = Console.ReadLine();
                    break;
                case "balance":
                    myAccount.GetBalance();
                    Console.WriteLine("What else would you like to do?");
                    answer = Console.ReadLine();
                    break;
                case "nothing":
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Try: Deposit, Withdraw, Balance, or Nothing");
                    answer = Console.ReadLine();

                    break;
            }
        }
            myAccount.GetBalance();
        }
    }
}
