using DeliveryMain;
using Xunit;

public class PriceTest
{
    [Fact]
    public void DeliveryFeeTest()
    {
        var order = new FoodOrder();
        order.AddItem(new FoodItem("Пицца", 50));

        IPay pay = new FixedPayment(0);
        decimal result = PriceServ.Instance.Calculate(order, pay);

        Assert.Equal(55, result);
    }
}
