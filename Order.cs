// Order.cs

using System;

public class Order
{
    public int OrderId { get; set; }
    public Product Product { get; set; }
    public Customer Customer { get; set; }
    public int Quantity { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        Product.DisplayInfo();
        Customer.DisplayInfo();
        Console.WriteLine($"Quantity: {Quantity}");
    }
}
