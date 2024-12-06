public class Product
{
    private string _name;
    private string _productID;
    private int _quantity;
    private int _price;

    public Product(string Name, string ProductID, int Quantity, int Price)
    {
        _name = Name;
        _productID = ProductID;
        _quantity = Quantity;
        _price = Price;
    
    }
    public int GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }

}