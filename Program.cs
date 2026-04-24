// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("Avishekh", 5000);

        try
        {
            account.Deposit(2000);     // valid
            account.Withdraw(7000);    // invalid
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine("Invalid Amount Error: " + ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Balance Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction Completed");
        }

        account.CheckBalance();
    }
}
