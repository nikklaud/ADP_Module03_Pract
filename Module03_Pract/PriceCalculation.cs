namespace Module03_Pract;

public class PriceCalculation
{
    public double Calculate(List<Product> products)
    {
        return products.Sum(p => p.Price);
    }
}