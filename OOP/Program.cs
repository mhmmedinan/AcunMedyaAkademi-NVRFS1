// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Hello, World!");


Product product = new Product();
product.Name = "Laptop";
//product.UnitPrice = 5000;


Product product2 = new Product();
product2.Name = null;
//product2.UnitPrice = 5000;


Console.WriteLine(product.Name);

//Console.WriteLine(product2.GetUnitPrice());

//Category category = new Category();
//category.Name = "Electronics";
//category.CreatedDate = DateTime.Now;

//Console.WriteLine(product.Id);
//Console.WriteLine(category.Name + " " + category.Id + " " + category.CreatedDate);


CategoryManager categoryManager = new CategoryManager();
List<Category> categories = categoryManager.GetCategories();

foreach (var item in categories)
{
    Console.WriteLine(item.Name);
}

Console.WriteLine("**********");

Category category1 = new Category();
category1.Name = "Kozmetik";
category1.CreatedDate = DateTime.Now;

categoryManager.Add(category1);

foreach (var item in categories)
{
    Console.WriteLine(item.Name);
}

