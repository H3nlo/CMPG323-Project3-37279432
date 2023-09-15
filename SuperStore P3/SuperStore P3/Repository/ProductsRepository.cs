using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        public ProductsRepository(SuperStoreContext context) : base(context)
        {
        }

        public Product GetMostRecentProduct()
        {
            return _context.Products.OrderByDescending(product => product.ProductId).FirstOrDefault();
        }
    }
    
}
