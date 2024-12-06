public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string Street, string City, string State, string Country)
    {
        _street = Street;
        _city = City;
        _state = State;
        _country = Country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }
    public virtual string ListAddress()
    {
        return $"{_street} {_city}, {_state}, {_country}";
    }
}