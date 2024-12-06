using System.Collections.Concurrent;
using System.IO.Pipes;

public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string Name, Address address)
    {
        _name = Name;
        _address = address;
    }

    public bool IsUsaCustomer()
    {
        return _address.IsInUSA();
    }
    public string GetName()
    {
        return _name;
    }

    public string Address()
    {
        return _address.ToString();
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_name} - {_address}");
    }
}