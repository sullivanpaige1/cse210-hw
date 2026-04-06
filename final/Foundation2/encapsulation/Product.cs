using System;

class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _qty;

    public Product(string name, int id, double price, int qty)
    {
        _name = name;
        _id = id;
        _price = price;
        _qty = qty;
    }

    public double TotalCost()
    {
        return _price * _qty;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }
}