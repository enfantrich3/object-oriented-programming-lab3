namespace DeliveryMain;

public class FoodItem
{
    public string Name { get; }
    public decimal Price { get; }

    public FoodItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}
