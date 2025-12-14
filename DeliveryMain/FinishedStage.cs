namespace DeliveryMain;

public class FinishedStage : IOrderStage
{
    public void Advance(FoodOrder order)
    {
        
    }

    public string Status()
    {
        return "Доставлен";
    }
}
