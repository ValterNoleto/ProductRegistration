using ProductRegistration.Api.Models;

namespace ProductRegistration.Api.Data
{
    public interface IProductRepository
    {
        void Create(Product product);
        Product Get(int id);
    }
}
