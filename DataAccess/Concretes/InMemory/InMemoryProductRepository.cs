using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.InMemory;

public class InMemoryProductRepository: IProductRepository
{

    private List<Product> _products;

    public InMemoryProductRepository()
    {
        _products = new List<Product>
        {
            //Seed Data
            new Product
            {
                Id = 1,
                Name = "Samsung S5",
                UnitPrice = 2000,
                Description = "Cheap Phone",
                Category = new Category
                {
                    Id = 1,
                    Name = "Electronics"
                }
            },
            new Product
            {
                Id = 2,
                Name = "Samsung S6",
                UnitPrice = 3000,
                Description = "Mid Range Phone",
                Category = new Category
                {
                    Id = 1,
                    Name = "Electronics"
                }
            },
            new Product
            {
                Id = 3,
                Name = "Samsung S7",
                UnitPrice = 4000,
                Description = "High End Phone",
                Category = new Category
                {
                    Id = 1,
                    Name = "Electronics"
                }
            }
        };
    }

    public void Add(Product product)
    {
        // Add product to database
        _products.Add(product);
    }

    public void Delete(int id)
    {
        Product? product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }

    public List<Product> GetAll()
    {
        return _products;
    }
}
