using Core.Entities;

namespace Entities;

public class Product:BaseEntity<int>
{
    public string Name { get; set; }
    public Category Category { get; set; }
    public decimal UnitPrice { get; set; }
    public string Description { get; set; }


    public Product()
    {
        
    }

    public Product(Category category,string name, decimal unitPrice, string description)
    {
        Name = name;
        UnitPrice = unitPrice;
        Description = description;
        Category = category;
    }
}
