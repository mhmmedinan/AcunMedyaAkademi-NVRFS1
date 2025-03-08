using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class ProductManager:IProductService
{
    
    private IProductRepository _repository;


    //lousely coupled
    public ProductManager(IProductRepository productRepository)
    {
       _repository = productRepository;
    }

    public void Add(Product product)
    {
        if (product.UnitPrice < 0)
        {
            throw new Exception("Price cannot be less than 0");
        }
        _repository.Add(product);
    }

    public List<Product> GetProducts()
    {
        return _repository.GetAll();
    }
}
