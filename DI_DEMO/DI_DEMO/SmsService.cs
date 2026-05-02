using System;

public class SmsService : IMessageService
{
    public void Send()
    {
        Console.WriteLine("SMS Sent");
    }
}