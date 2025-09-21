namespace Module03_Pract.Payment;

public class PayPal : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Payment for {amount} from paypal");
    }
}