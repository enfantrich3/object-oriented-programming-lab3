namespace DeliveryMain;

public abstract class OrderFactory
{
    public abstract FoodOrder Create();
}

public class DefaultOrderFactory : OrderFactory
{
    public override FoodOrder Create()
    {
        return new FoodOrder();
    }
}
