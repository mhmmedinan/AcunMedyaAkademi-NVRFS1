using Entities;

namespace DataAccess.Abstracts;

public interface ICategoryRepository
{
    void Add(Category category);
    void Delete(int id);
    List<Category> GetAll();
}
