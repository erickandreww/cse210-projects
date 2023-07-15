// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.

using System;

public class Product 
{
    // variables to each product information
    private string _productName;
    private int _productID;
    private float _productPrice;
    private int _productQuantity;

    // a construtor to set the products info
    public Product(string name, float price, int quantity, int id) 
    {
        _productName = name;
        _productPrice = price;
        _productQuantity = quantity;
        _productID = id;
    }

    // a contrutor only to call the get price method
    public Product(float price, int quantity)
    {
        _productPrice = price;
        _productQuantity = quantity;
    }

    // a method to get the price os the products (quantity x price)
    public float GetPrice() 
    {
        return _productPrice * _productQuantity;
    }

    // a method to get the product name and ID
    public string GetProduct() 
    {
        return $"{_productName}, ID:#{_productID}";
    }
}

