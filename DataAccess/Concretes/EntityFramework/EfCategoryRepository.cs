using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework;

public class EfCategoryRepository : ICategoryRepository
{
    public void Add(Category category)
    {
        Console.WriteLine($"{category.Name} added to database");
    }

    public void Delete(int id)
    {
        Console.WriteLine($"{id} deleted from database");
    }

    public List<Category> GetAll()
    {
        List<Category> categories = new List<Category>();
        return categories;
    }
}
