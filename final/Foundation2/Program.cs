using System;

class Program
{
    static void Main(string[] args)
    {
        Address a = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer c = new Customer("Alice", a);
        Order o = new Order(c);

        o.AddProduct(new Product("Laptop", 1, 800, 1));
        o.AddProduct(new Product("Mouse", 2, 20, 2));

        Console.WriteLine(o.PackingLabel());
        Console.WriteLine(o.ShippingLabel());
        Console.WriteLine("Total: $" + o.TotalPrice());
    }
}