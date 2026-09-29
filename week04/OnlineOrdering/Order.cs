using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product product in _products)
        {
            label += "Item: " + product.GetName() + " (ID: " + product.GetProductId() + ")\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "--- SHIPPING LABEL ---\n" + _customer.GetName() + "\n" + _customer.GetAddress().GetFullAddress() + "\n";
    }
}