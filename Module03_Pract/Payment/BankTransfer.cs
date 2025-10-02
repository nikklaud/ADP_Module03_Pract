namespace Module03_Pract.Payment;

public class BankTransfer: IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Bank Transfer Payment {amount}");
    }
}