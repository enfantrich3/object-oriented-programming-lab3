using DeliveryMain;
using Xunit;

public class PaymentTest
{
    [Fact]
    public void PercentTest()
    {
        IPay pay = new PercentPayment(10);
        decimal result = pay.Apply(100);

        Assert.Equal(90, result);
    }

    [Fact]
    public void FixedTest()
    {
        IPay pay = new FixedPayment(20);
        decimal result = pay.Apply(100);

        Assert.Equal(80, result);
    }
}
