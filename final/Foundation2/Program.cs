using System;

namespace OrderSystem
{
    class Address
    {
        private string Street, City, State, Country;

        public Address(string street, string city, string state, string country)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
        }

        public bool IsUSA()
        {
            return Country.ToUpper() == "USA";
        }

        public override string ToString()
        {
            return $"{Street}\n{City}, {State}\n{Country}";
        }
    }

    class Customer
    {
        private string Name;
        private Address Address;

        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public bool LivesInUSA()
        {
            return Address.IsUSA();
        }

        public string GetName()
        {
            return Name;
        }

        public string GetAddress()
        {
            return Address.ToString();
        }
    }

    class Product
    {
        private string Name;
        private int ProductId;
        private double Price;
        private int Quantity;

        public Product(string name, int id, double price, int quantity)
        {
            Name = name;
            ProductId = id;
            Price = price;
            Quantity = quantity;
        }

        public double TotalCost()
        {
            return Price * Quantity;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetId()
        {
            return ProductId;
        }
    }

    class Order
    {
        private Customer Customer;
        private List<Product> Products = new List<Product>();

        public Order(Customer customer)
        {
            Customer = customer;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public double TotalPrice()
        {
            double shipping;

            if (Customer.LivesInUSA())
                shipping = 5;
            else
                shipping = 35;

            double total = 0;

            foreach (Product p in Products)
            {
                total += p.TotalCost();
            }

            return total + shipping;
        }

        public string PackingLabel()
        {
            string label = "Packing Label:\n";

            foreach (Product p in Products)
            {
                label += p.GetName() + " (ID: " + p.GetId() + ")\n";
            }

            return label;
        }

        public string ShippingLabel()
        {
            return "Shipping Label:\n" +
                   Customer.GetName() + "\n" +
                   Customer.GetAddress();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
            Customer cust1 = new Customer("Alice Smith", addr1);
            Order order1 = new Order(cust1);

            order1.AddProduct(new Product("Laptop", 101, 799.99, 1));
            order1.AddProduct(new Product("Mouse", 102, 25.50, 2));

            Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
            Customer cust2 = new Customer("Bob Jones", addr2);
            Order order2 = new Order(cust2);

            order2.AddProduct(new Product("Keyboard", 201, 49.99, 1));
            order2.AddProduct(new Product("Monitor", 202, 199.99, 1));

            List<Order> orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);

            foreach (Order order in orders)
            {
                Console.WriteLine(order.PackingLabel());
                Console.WriteLine(order.ShippingLabel());
                Console.WriteLine("Total Price: $" + order.TotalPrice().ToString("F2"));
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}