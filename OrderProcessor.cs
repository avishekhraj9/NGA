using System;

public delegate void OrderPlacedHandler(Order order);

public class OrderProcessor
{
    // Event
    public event OrderPlacedHandler OnOrderPlaced;

    public void PlaceOrder(Order order)
    {
        Console.WriteLine($"Order Placed: {order.OrderId}");

        // Trigger event
        OnOrderPlaced?.Invoke(order);
    }
}