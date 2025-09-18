namespace Module03_Pract;

public interface IDelivery
{
    public void ProcessDelivery(Order order);
}

class CourierDelivery : IDelivery
{
    public void ProcessDelivery(Order order)
    {
        Console.WriteLine($"Delivery for {order} from courier");
    }
}

class PostDelivery : IDelivery
{
    public void ProcessDelivery(Order order)
    {
        Console.WriteLine($"Delivery for {order} from post");
    }
}

class PickUpPointDelivery : IDelivery
{
    public void ProcessDelivery(Order order)
    {
        Console.WriteLine($"Delivery for {order} from pickup");
    }
        
}