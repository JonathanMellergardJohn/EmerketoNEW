using Emerketo.Areas.Identity.Data;

namespace Emerketo.Models
{

    public class ProductRepository : IProductRepository
    {
        private readonly EmerketoDbContext _emerketoContext;

        public ProductRepository(EmerketoDbContext emerketoContext)
        {
            _emerketoContext = emerketoContext;
        }

        public IEnumerable<Product> AllProducts 
        {
            get
            {
                return _emerketoContext.Products;
            }            
        }
        public IEnumerable<Product> NewProducts 
        { 
            get 
            {
                return _emerketoContext.Products.Where(p => p.IsNew == true);
            } 
        }
        public IEnumerable<Product> PopularProducts 
        {
            get 
            {
                return _emerketoContext.Products.Where(p => p.IsPopular == true);
            } 
        }
        public IEnumerable<Product> FeaturedProducts 
        { 
            get
            {
                return _emerketoContext.Products.Where(p => p.IsFeatured == true);
            }                
        }
        public Product? GetProductById(int id)
        {
            return _emerketoContext.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
