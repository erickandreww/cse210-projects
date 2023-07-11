// Contains a list of products and a customer. 
// Can calculate the total cost of the order, 
// and can return a string for the packing label, 
// and can return a string for the shipping label.
// The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer

using System;

public class Order 
{
    private List<List<string>> _products = new List<List<string>>();
    private List<string> _customer = new List<string>();

    public Order(List<List<string>> products, List<string> customer) 
    {
        _products = products;
        _customer = customer;
    }

    public string ShippingLabel()
    {
        Address ad = new Address(_customer[1], _customer[2], _customer[3],_customer[4]);
        Customer custom = new Customer(_customer[0]);         
        return "";
    }

    public string PackingLabel()
    {
        foreach (List<string> product in _products) {
            Product packing = new Product(product[0], float.Parse(product[1]), int.Parse(product[2]), int.Parse(product[3]));
        }
        return "";
    }

    public float TotalCost() 
    {
        float total = 0;
        foreach (List<string> product in _products) {
            Product calculate = new Product(float.Parse(product[2]), int.Parse(product[3]));
            total += calculate.GetPrice();
        }
        return total;
    }

}