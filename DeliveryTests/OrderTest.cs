using DeliveryMain;
using Xunit;

public class OrderTest
{
    [Fact]
    public void AddItemTest()
    {
        var order = new FoodOrder();
        order.AddItem(new FoodItem("Бургер", 10));

        Assert.Equal(10, order.TotalCost);
    }

    [Fact]
    public void StartStageTest()
    {
        var order = new FoodOrder();

        Assert.Equal("Готовится", order.GetStatus());
    }
}
