using System;

namespace workshops_cs_bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankAccount Account1 = new BankAccount(12345, "Ellie", 500);
            Console.WriteLine($"{Account1.Id}, {Account1.Owner}, {Account1.Balance}");
            Account1.MakeDeposit(50);
            Account1.MakeWithdrawal(400);
            Account1.ChangeName("Roxy");
            Console.WriteLine($"The account owner has changed to: {Account1.Owner}");
        }

    }
}
