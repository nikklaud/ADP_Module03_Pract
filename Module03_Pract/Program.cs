// See https://aka.ms/new-console-template for more information

using Module03_Pract;

internal class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        Product product2 = new Product();
        Product product3 = new Product();

        Order order = new Order();
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);
        
        Console.WriteLine($"Select method of delivery(1-courier, 2-post, 3-PickUpPoint): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        IDelivery delivery = null;
        switch (choice)
        {
            case 1:
                delivery = new CourierDelivery();
                break;
            case 2:
                delivery = new PostDelivery();
                break;
            case 3:
                delivery = new PickUpPointDelivery();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        delivery.ProcessDelivery(order);
    }
}
