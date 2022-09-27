using ProductRegistration.Api.Models;

namespace ProductRegistration.Api.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public Product Get(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
