// ShoppingSystem.cs

class ShoppingSystem
{
    static void Main()
    {
        // Create products
        Product product1 = new Product { ProductId = 1, Name = "Laptop", Price = 800.0m };
        Product product2 = new Product { ProductId = 2, Name = "Smartphone", Price = 400.0m };

        // Create customers
        Customer customer1 = new Customer { CustomerId = 101, Name = "Alice", Email = "alice@example.com" };
        Customer customer2 = new Customer { CustomerId = 102, Name = "Bob", Email = "bob@example.com" };

        // Create orders
        Order order1 = new Order { OrderId = 1001, Product = product1, Customer = customer1, Quantity = 2 };
        Order order2 = new Order { OrderId = 1002, Product = product2, Customer = customer2, Quantity = 1 };

        // Display information
        System.Console.WriteLine("Order Information:");
        order1.DisplayInfo();
        System.Console.WriteLine();
        order2.DisplayInfo();
    }
}
