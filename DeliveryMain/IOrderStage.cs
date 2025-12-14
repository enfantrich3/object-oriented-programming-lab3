namespace DeliveryMain;

public interface IOrderStage
{
    void Advance(FoodOrder order);
    string Status();
}
