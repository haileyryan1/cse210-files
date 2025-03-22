using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Jack Johnson", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "12345", 299.99, 12));
        order1.AddProduct(new Product("Mouse", "67891", 19.99, 18));

        Address addr2 = new Address("15 Street Ave", "Buenos Aires", "BA", "Argentina");
        Customer cust2 = new Customer("Jorge Alvarez", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Monitor", "24681", 249.99, 10));
        order2.AddProduct(new Product("Keyboard", "13579", 30.00, 16));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}