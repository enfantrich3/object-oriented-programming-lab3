namespace DeliveryMain;

public class OrderBuilder
{
    private readonly FoodOrder order = new();

    public OrderBuilder AddFood(FoodItem item)
    {
        order.AddItem(item);
        return this;
    }

    public FoodOrder Build()
    {
        return order;
    }
}
