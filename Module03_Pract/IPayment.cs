namespace Module03_Pract;

public interface IPayment
{
    void ProcessPayment(double amount);
}

public class CreditCard : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Payment for {amount} from creditcard");
    }
}

public class PayPal : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Payment for {amount} from paypal");
    }
}