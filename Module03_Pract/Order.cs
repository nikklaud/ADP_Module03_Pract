namespace Module03_Pract;

public class Order
{
    private List<Product> _products;

    public Order()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}