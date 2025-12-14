namespace DeliveryMain;

public class CookingStage : IOrderStage
{
    public void Advance(FoodOrder order)
    {
        order.CurrentStage = new SendingStage();
    }

    public string Status()
    {
        return "Готовится";
    }
}
