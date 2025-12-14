namespace DeliveryMain;

public class PercentPayment : IPay
{
    private readonly decimal percent;

    public PercentPayment(decimal percent)
    {
        this.percent = percent;
    }

    public decimal Apply(decimal total)
    {
        return total - (total * percent / 100);
    }
}
