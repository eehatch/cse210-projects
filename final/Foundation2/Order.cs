public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products , Customer customer)
    {
        _customer = customer;
        _products = products;

    }
    public double TotalPrice()
    {
        double total = 0;
        double ShippingCost = _customer.IsUsaCustomer() ? 5 : 35;
        total += ShippingCost;
        return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()}: {product.GetProductID()}";
        }
        return label;
    
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.Address()}";
        
    }
}