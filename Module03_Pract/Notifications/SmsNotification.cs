namespace Module03_Pract.Notifications;

public class SmsNotification: INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}