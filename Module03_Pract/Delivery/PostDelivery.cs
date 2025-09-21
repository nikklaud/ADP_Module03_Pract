namespace Module03_Pract.Delivery;

public class PostDelivery : IDelivery
{
    public void ProcessDelivery(Order order)
    {
        Console.WriteLine($"Delivery for {order} from post");
    }
}