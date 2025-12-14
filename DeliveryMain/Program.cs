namespace DeliveryMain;

public static class Program
{
    public static void Main()
    {
        OrderFactory factory = new DefaultOrderFactory();
        FoodOrder order = factory.Create();

        var builder = new OrderBuilder();
        order = builder
            .AddFood(new FoodItem("Чизбургер", 11.99m))
            .AddFood(new FoodItem("Фанта", 2.49m))
            .Build();

        Console.WriteLine("Стоимость: " + order.TotalCost);

        IPay discount = new PercentPayment(10);
        decimal finalPrice = PriceServ.Instance.Calculate(order, discount);

        Console.WriteLine("Итого со скидкой: " + finalPrice);

        Console.WriteLine(order.GetStatus());
        order.NextStage();
        Console.WriteLine(order.GetStatus());
        order.NextStage();
        Console.WriteLine(order.GetStatus());
    }
}
