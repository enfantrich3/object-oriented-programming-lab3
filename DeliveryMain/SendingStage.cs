namespace DeliveryMain;

public class SendingStage : IOrderStage
{
    public void Advance(FoodOrder order)
    {
        order.CurrentStage = new FinishedStage();
    }

    public string Status()
    {
        return "В доставке";
    }
}
