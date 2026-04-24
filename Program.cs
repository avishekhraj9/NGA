// See https://aka.ms/new-console-template for more information
// Banking Transaction System

using System;
using System.Collections.Generic;

class Transaction
{
    public string TransactionId;
    public double Amount;

    public Transaction(string transactionId, double amount)
    {
        TransactionId = transactionId;
        Amount = amount;
    }
}

class BankingSystem
{
    private List<Transaction> transactionHistory = new List<Transaction>();
    private Dictionary<string, double> accountBalances = new Dictionary<string, double>();
    private Queue<Transaction> pendingTransaction = new Queue<Transaction>();
    private Stack<Transaction> rollbackStack = new Stack<Transaction>();
    private HashSet<string> transactionIds = new HashSet<string>();

    public void CreateAccount(string accountId, double initialBalance)
    {
        accountBalances[accountId] = initialBalance;
        Console.WriteLine("Account created: " + accountId + " with balance: " + initialBalance);
    }

    public void AddTransaction(string transactionId, double amount)
    {
        if (transactionIds.Contains(transactionId))
        {
            Console.WriteLine("Transaction ID already exists: " + transactionId);
            return;
        }
        Transaction transaction = new Transaction(transactionId, amount);
        pendingTransaction.Enqueue(transaction);
        transactionIds.Add(transactionId);
        Console.WriteLine("Transaction added: " + transactionId + " with amount: " + amount);
    }

    public void ProcessTransaction(string accoundId)
    {
        if (pendingTransaction.Count == 0)
        {
            Console.WriteLine("No pending transactions to process.");
            return;
        }
        if (!accountBalances.ContainsKey(accoundId))
        {
            Console.WriteLine("Account does not exist: " + accoundId);
            return;
        }
        Transaction transaction = pendingTransaction.Dequeue();
        accountBalances[accoundId] += transaction.Amount;
        transactionHistory.Add(transaction);
        rollbackStack.Push(transaction);
        Console.WriteLine($"Processed transaction: {transaction.TransactionId} for account: {accoundId}. New balance: {accountBalances[accoundId]}");
    }


    public void RollbackTransaction(string accoundId)
    {
        if (rollbackStack.Count == 0)
        {
            Console.WriteLine("No transactions to rollback.");
            return;
        }
        if (!accountBalances.ContainsKey(accoundId))
        {
            Console.WriteLine("Account does not exist: " + accoundId);
            return;
        }
        Transaction transaction = rollbackStack.Pop();
        accountBalances[accoundId] -= transaction.Amount;
        transactionHistory.Remove(transaction);
        Console.WriteLine($"Rolled back transaction: {transaction.TransactionId} for account: {accoundId}. New balance: {accountBalances[accoundId]}");
    }


    public void ShowBalance(string accountId)
    {
        if (accountBalances.ContainsKey(accountId))
        {
            Console.WriteLine("Account: " + accountId + ", Balance: " + accountBalances[accountId]);
        }
        else
        {
            Console.WriteLine("Account does not exist: " + accountId);
        }
    }


    public void ShowHistory()
    {
        Console.WriteLine("Transaction History:");
        foreach (var transaction in transactionHistory)
        {
            Console.WriteLine($"Transaction ID: {transaction.TransactionId}, Amount: {transaction.Amount}");
        }
    }

}






class Program
{
    static void Main()
    {
        BankingSystem bank = new BankingSystem();
        bank.CreateAccount("A001", 1000);

        bank.AddTransaction("T001", 200);
        bank.AddTransaction("T002", -150);
        bank.AddTransaction("T003", 300);


        bank.ProcessTransaction("A001");
        bank.ProcessTransaction("A001");


        bank.ShowBalance("A001");


        bank.ShowHistory();

        bank.RollbackTransaction("A001");

        bank.ShowBalance("A001");

    }
}

