namespace OOP;

public class Category:BaseEntity<int>
{
    public string Name { get; set; }
  


    //yapıcı metot

    public Category()
    {
        Console.WriteLine("Yapıcı blok çalıştı");
        Name = string.Empty!;
        Id++;
    }

    public Category(int id,string name)
    {
        Name = name;
    }
}
