using System;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double TotalPrice()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.TotalCost();
        }

        if (_customer.LivesInUSA())
            total += 5;
        else
            total += 35;

        return total;
    }

    public string PackingLabel()
    {
        string result = "Packing Label:\n";

        foreach (Product p in _products)
        {
            result += p.GetName() + " ID: " + p.GetId() + "\n";
        }

        return result;
    }

    public string ShippingLabel()
    {
        return "Shipping Label:\n" +
               _customer.GetName() + "\n" +
               _customer.GetAddress();
    }
}