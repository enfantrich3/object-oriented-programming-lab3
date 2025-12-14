using DeliveryMain;

namespace DeliveryMain;

public class PriceServ
{
    private static PriceServ? instance;

    public static PriceServ Instance
        => instance ??= new PriceServ();

    private PriceServ() { }

    public decimal Calculate(FoodOrder order, IPay strategy)
    {
        decimal price = order.TotalCost;


        price += 5;

        return strategy.Apply(price);
    }
}
