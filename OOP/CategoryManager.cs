namespace OOP;

public class CategoryManager
{

    private List<Category> _categories;

    public CategoryManager()
    {
        //Singleton Pattern
        _categories = new List<Category>();
        _categories.Add(new Category(1,"Elektronik"));
        _categories.Add(new Category{Id = 2,Name ="Oyuncak"});
    }


    public void Add(Category category)
    {
        _categories.Add(category);
    }


    public List<Category> GetCategories()
    {
        return _categories;
    }
}


//User sınıfımız olacak
//User sınıfı BaseEntity sınıfından türeyecek
//User sınıfında Name,Email,Password,FirstName propertyleri olacak
//Student,Instructor sınıfları olacak
//StundetManager adında bir operasyon sınıfınız olsun.
//Add,Getlist,Delete,GetById operasyonları olsun

