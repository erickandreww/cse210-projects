// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

using System;

public class Customer
{
    private string _costumerName;
    private List<string> _costumerAdress;

    public Customer(string name, List<string> address) 
    {
        _costumerName = name;
    }

    public void WhereLive(string addressContent) 
    {
        // _costumerAdress = GetAddress();
    }
}