using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework;

public class EfProductRepository:IProductRepository
{

    public void Add(Product product)
    {
        Console.WriteLine($"{product.Name} added to database");
    }

    public void Delete(int id)
    {
        Console.WriteLine($"{id} deleted from database");
    }

    public List<Product> GetAll()
    {
        List<Product> products = new List<Product>();
        return products;
    }
}
