using System.Collections.Generic;

namespace DeliveryMain;

public class FoodOrder
{
    public IOrderStage CurrentStage { get; set; }

    public decimal TotalCost { get; private set; }

    private List<FoodItem> items = new();

    public FoodOrder()
    {
        CurrentStage = new PreparingStage();
    }

    public void AddItem(FoodItem item)
    {
        items.Add(item);
        TotalCost += item.Price;
    }

    public void NextStage()
    {
        CurrentStage.Advance(this);
    }

    public string GetStatus()
    {
        return CurrentStage.Status();
    }
}
