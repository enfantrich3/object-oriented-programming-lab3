using DeliveryMain;
using Xunit;

public class StageTest
{
    [Fact]
    public void StageFlowTest()
    {
        var order = new FoodOrder();

        order.NextStage();
        Assert.Equal("В доставке", order.GetStatus());

        order.NextStage();
        Assert.Equal("Доставлен", order.GetStatus());
    }
}
