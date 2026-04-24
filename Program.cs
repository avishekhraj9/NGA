using System;
using System.Collections.Generic;

class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
}

class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public string Product { get; set; }
    public string Category { get; set; }

    public Stack<string> StatusHistory { get; set; } = new Stack<string>();
}

class Program
{
    static List<Order> orders = new List<Order>();
    static Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
    static HashSet<string> categories = new HashSet<string>();
    static Queue<Order> orderQueue = new Queue<Order>();

    static int orderCounter = 1;

    static void Main()
    {
        //9620804863

          //  08065159555
        while (true)
        {
            Console.WriteLine("\n--- E-Commerce Order System ---");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. Process Order");
            Console.WriteLine("4. View Orders");
            Console.WriteLine("5. View Categories");
            Console.WriteLine("6. Exit");

            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: AddCustomer(); break;
                case 2: PlaceOrder(); break;
                case 3: ProcessOrder(); break;
                case 4: ViewOrders(); break;
                case 5: ViewCategories(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }

    static void AddCustomer()
    {
        Console.Write("Enter Customer ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        customers[id] = new Customer { CustomerId = id, Name = name };

        Console.WriteLine("Customer added!");
    }

    static void PlaceOrder()
    {
        Console.Write("Enter Customer ID: ");
        int custId = int.Parse(Console.ReadLine());

        if (!customers.ContainsKey(custId))
        {
            Console.WriteLine("Customer not found!");
            return;
        }

        Console.Write("Enter Product: ");
        string product = Console.ReadLine();

        Console.Write("Enter Category: ");
        string category = Console.ReadLine();

        Order order = new Order
        {
            OrderId = orderCounter++,
            CustomerId = custId,
            Product = product,
            Category = category
        };

        order.StatusHistory.Push("Order Placed");

        orders.Add(order);
        orderQueue.Enqueue(order);
        categories.Add(category);

        Console.WriteLine("Order placed successfully!");
    }

    static void ProcessOrder()
    {
        if (orderQueue.Count == 0)
        {
            Console.WriteLine("No orders to process!");
            return;
        }

        Order order = orderQueue.Dequeue();
        order.StatusHistory.Push("Processed");

        Console.WriteLine($"Order {order.OrderId} processed.");
    }

    static void ViewOrders()
    {
        foreach (var order in orders)
        {
            Console.WriteLine($"OrderID: {order.OrderId}, Product: {order.Product}");

            Console.Write("Status History: ");
            foreach (var status in order.StatusHistory)
            {
                Console.Write(status + " -> ");
            }
            Console.WriteLine();
        }
    }

    static void ViewCategories()
    {
        Console.WriteLine("Unique Categories:");
        foreach (var cat in categories)
        {
            Console.WriteLine(cat);
        }
    }
}