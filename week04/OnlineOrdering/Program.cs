using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: Customer lives in the USA
        Address address1 = new Address("456 Apple St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Wireless Mouse", "M201", 25.00, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "K502", 80.00, 1));

        // Order 2: International Customer (Burundi)
        Address address2 = new Address("Avenue de la JRR", "Bujumbura", "Mairie", "Burundi");
        Customer customer2 = new Customer("Emmanuel Sendegeya", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Laptop Stand", "S103", 45.00, 1));
        order2.AddProduct(new Product("USB-C Hub", "H904", 15.00, 3));

        // Display Order 1 Details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Order Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine("\n==================================================\n");

        // Display Order 2 Details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Order Cost: $" + order2.CalculateTotalCost());
    }
}