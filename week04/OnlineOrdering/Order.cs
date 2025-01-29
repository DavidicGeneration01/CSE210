using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

public class order
{
    private List<Product> _products;
    private Customer _customers;

    public order(Customer customer)
    {
        this._customers = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.ProductCost();
        }
        totalCost += Customer.Live
    }
}