using System;

public class InvalidAmountException : Exception
{
    public InvalidAmountException(string message) : base(message)
    {
    }
}