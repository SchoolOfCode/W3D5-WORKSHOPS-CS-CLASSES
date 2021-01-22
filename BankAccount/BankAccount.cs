using System;
public class BankAccount
{
    public long Id;
    public string Owner;
    public decimal Balance;
    public BankAccount(long id, string owner, decimal balance)
    {
        Id = id;
        Owner = owner;
        Balance = balance;
    }
    public void MakeDeposit(decimal savings)
    {
        Balance += savings;
        Console.WriteLine($"You have deposited {savings}, your balance is now {Balance}");
    }
    public decimal MakeWithdrawal(decimal withdrawal)
    {
        Balance -= withdrawal;
        Console.WriteLine($"You have withdrawn {withdrawal}, your balance is now {Balance}");
        return Balance;
    }
}