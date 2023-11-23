namespace models;

public class Order
{
    private readonly List<Product> _products = [];
    public int Id { get; set; }
    public bool Processed { get; private set; }
    public IReadOnlyList<Product> Products => _products.ToArray();
    public decimal TotalPrice => Products.Sum(p => p.Price);

    public void AddProduct(Product product)
    {
        // TODO: Implement the method that adds a product to this order
        throw new NotImplementedException();
    }

    public void RemoveProduct(int id)
    {
        // TODO: Implement the method that removes a specific product from the order based on its Id
        throw new NotImplementedException();
    }

    public void ChangeOrderStatus(bool status)
    {
        Processed = status;
    }
}