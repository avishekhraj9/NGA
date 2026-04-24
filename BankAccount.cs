using System;

public class BankAccount
{
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }

    public BankAccount(string name, double balance)
    {
        AccountHolderName = name;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new InvalidAmountException("Deposit amount must be greater than 0");
        }

        Balance += amount;
        Console.WriteLine($"Deposited: ₹{amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Insufficient balance");
        }

        if (Balance - amount < 1000)
        {
            throw new InsufficientBalanceException("Minimum balance ₹1000 required");
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawn: ₹{amount}");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: ₹{Balance}");
    }
}