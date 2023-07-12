// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.

using System;

public class Product 
{
    private string _productName;
    private int _productID;
    private float _productPrice;
    private int _productQuantity;

    public Product(string name, float price, int quantity, int id) 
    {
        _productName = name;
        _productPrice = price;
        _productQuantity = quantity;
        _productID = id;
    }

    public Product(float price, int quantity)
    {
        _productPrice = price;
        _productQuantity = quantity;
    }

    public float GetPrice() 
    {
        return _productPrice * _productQuantity;
    }

    public string GetProduct() 
    {
        return $"{_productName}, ID:#{_productID}";
    }
}

