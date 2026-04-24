// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create objects
        OrderProcessor processor = new OrderProcessor();

        EmailService emailService = new EmailService();
        SMSService smsService = new SMSService();
        LoggerService loggerService = new LoggerService();

        // Subscribe methods
        processor.OnOrderPlaced += emailService.SendEmail;
        processor.OnOrderPlaced += smsService.SendSMS;
        processor.OnOrderPlaced += loggerService.LogOrder;

        // Create order
        Order order = new Order
        {
            OrderId = 101,
            CustomerName = "Avishek",
            Amount = 5000
        };

        // Place order
        processor.PlaceOrder(order);

        Console.ReadLine();
    }
}
