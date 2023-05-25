namespace Emerketo.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts {  get; }
        IEnumerable<Product> NewProducts { get; }
        IEnumerable<Product> PopularProducts { get; }
        IEnumerable<Product> FeaturedProducts { get; }
        Product? GetProductById (int id);
    }
}
