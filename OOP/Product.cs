namespace OOP;

public class Product:BaseEntity<Guid>
{

    private string name;
    private double unitPrice;



    public string Name {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;                 // değer boş değilse
            else
                Console.WriteLine("Name cannot be empty!");
           
        } 
    }

    //PascalCase
    public double UnitPrice { get { return unitPrice; } } // sadece okunabilir

    public Product()
    {
        Id = Guid.NewGuid();
    }


    //public void SetUnitPrice(double price)
    //{
    //    if (price > 0)
    //        UnitPrice = price;
    //    else
    //        Console.WriteLine("Price must be greater than 0!");
    //}

    //public double GetUnitPrice()
    //{
    //    return UnitPrice;
    //}

}
