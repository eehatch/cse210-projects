class Program
{
    static void Main(string[] args)
    {
        Address addressUsa = new Address("12345 st", "Rexburg", "Idaho", "USA");
        Address addressNot = new Address("6789 st", "Surrey", "British Columbia", "Canada");

        Customer customer1 = new Customer("Emily Hatch", addressUsa);
        Customer customer2 = new Customer("Emma Hoyle", addressNot);

        Product product1 = new Product("Shirt", "S123", 1, 75);
        Product product2 = new Product("Candle", "C123", 3, 15);
        Product product3 = new Product("Laptop", "L145", 1, 500);
        Product product4 = new Product("Blanket", "B45", 1, 50);

        Order order1 = new Order(new List<Product> {product1, product4 }, customer1, addressNot);
        Order order2 = new Order(new List<Product> {product2, product3 }, customer2, addressUsa);

        Console.WriteLine($"\n------Order 1 Packing Label------ \n{order1.PackingLabel()}");
        Console.WriteLine($"------Shipping Label------ \n{order1.ShippingLabel()}");
        Console.WriteLine($"Order 1 Total Price: {order1.TotalPrice()}\n");

        Console.WriteLine($"------Order 2 Packing Label------ \n{order2.PackingLabel()}");
        Console.WriteLine($"------Shipping Label------\n{order2.ShippingLabel()}");
        Console.WriteLine($"Order 2 Total Price: {order2.TotalPrice()}");
    
    }
}