namespace DeliveryMain;

public class PreparingStage : IOrderStage
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
