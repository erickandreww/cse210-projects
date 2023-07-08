// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.

using System;

public class product 
{
    private string _productName;
    private int _productPrice;
    private int _productQuantity;

    public int getPrice() 
    {
        return _productPrice * _productQuantity;
    }

}

