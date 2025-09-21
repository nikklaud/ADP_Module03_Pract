namespace Module03_Pract.Payment;

public class CreditCard : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Payment for {amount} from creditcard");
    }
}