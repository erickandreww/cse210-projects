// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

using System;

public class Customer
{
    private string _costumerName;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country) 
    {
        _costumerName = name;
        _address = new Address(street, city, state, country);
    }

    public bool WhereLive() 
    {
        return _address.IsUsa();
    }

    public string GetCostumerAddress() 
    {
        return _address.GetAddress();
    }

    public string GetCostumerName()
    {
        return _costumerName;
    }
}