namespace Module03_Pract.Notifications;

public class EmailNotification:  INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}