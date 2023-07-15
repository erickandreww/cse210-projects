// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

using System;

public class Customer
{
    // Variables to hold the customer name and Address class
    private string _costumerName;
    private Address _address;

    // A method to set the name and all address of the customer
    public Customer(string name, string street, string city, string state, string country) 
    {
        _costumerName = name;
        _address = new Address(street, city, state, country);
    }

    // a method to return if the user live or not in USA
    public bool WhereLive() 
    {
        return _address.IsUsa();
    }

    // a method to get the customer address
    public string GetCostumerAddress() 
    {
        return _address.GetAddress();
    }

    // a method to get the customer name
    public string GetCostumerName()
    {
        return _costumerName;
    }
}