// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)

using System;

public class Address
{
    // variables to hold all address info
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // A method to set the complete address
    public Address(string street, string city, string state, string country) 
    {
        _street = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }

    // A method to verify if the customer lives in USA
    public bool IsUsa()
    {
        if (_country == "USA") {
            return true;
        }
        else {
            return false;
        }
    }

    // A method to get the Address
    public string GetAddress() {
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
    }
}