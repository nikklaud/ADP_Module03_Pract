namespace Module03_Pract.Delivery;

public class PickUpPointDelivery : IDelivery
{
    public void ProcessDelivery(Order order)
    {
        Console.WriteLine($"Delivery for {order} from pickup");
    }
        
}