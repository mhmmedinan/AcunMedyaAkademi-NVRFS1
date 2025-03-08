using Entities;

namespace DataAccess.Abstracts;

public interface IProductRepository
{
    void Add(Product product);
    void Delete(int id);
    List<Product> GetAll();
}
