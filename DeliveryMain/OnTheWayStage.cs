namespace DeliveryMain;

public class OnTheWayStage : IOrderStage
{
    public void Advance(FoodOrder order)
    {
        order.CurrentStage = new FinishedStage();
    }

    public string Status()
    {
        return "Передан курьеру";
    }
}
