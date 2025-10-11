using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //Displaying full order as needed
    public void DisplayOrder()
    {
        Console.WriteLine("Packing Label:");
        foreach (var product in _products)
        {
            Console.WriteLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }

        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().GetFullAddress());

        double subtotal = 0;
        foreach (var product in _products)
        {
            double cost = product.GetTotalCost();
            subtotal += cost;
            Console.WriteLine($"{product.GetName()} - {product.GetProductId()} : ${cost}");
        }

        double shipping = _customer.LivesInUSA() ? 5 : 35;
        double total = subtotal + shipping;

        Console.WriteLine($"Subtotal: ${subtotal}");
        Console.WriteLine($"Shipping: ${shipping}");
        Console.WriteLine($"TOTAL:    ${total}");
    }
}