namespace Module03_Pract.Delivery;

public class CourierDelivery : IDelivery
{
    public void ProcessDelivery(Order order)
    {
        Console.WriteLine($"Delivery for {order} from courier");
    }
}