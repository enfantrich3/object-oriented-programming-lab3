namespace DeliveryMain;

public class FixedPayment : IPay
{
    private readonly decimal amount;

    public FixedPayment(decimal amount)
    {
        this.amount = amount;
    }

    public decimal Apply(decimal total)
    {
        return total - amount;
    }
}
