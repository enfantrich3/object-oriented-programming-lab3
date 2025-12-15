namespace DeliveryMain;

public class DefaultOrderFactory : OrderFactory
{
    public override FoodOrder Create()
    {
        return new FoodOrder();
    }
}