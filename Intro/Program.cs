// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Hello, World!");


//Veriables

// Camel Case
string productName = "Casper Excalibur";
int productPrice = 269;  // 32 bit // 2 byte -2,147,483,648 - 2,147,483,647
long productPrice1 = 269; // 64 bit 8 byte 
byte productPrice2= 255; // 8bit 
short productPrice3 = 32767;


double productPrice4 = 269.99;
float productPrice5 = 268.99F;
decimal productPrice6 = 269.98M;
char gender = 'A';

// matematiksel işlem yapılmayan her tam sayı bir string veri tipine atanır.




Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productName);
Console.WriteLine(productPrice);


int number1 = 10;
int number2 = 10;

if (number1 < number2)
{
    Console.WriteLine(number2 + "büyüktür");

}
else if (number2  < number1)
{
    Console.WriteLine(number1 + "büyüktür");
}
else
{
    Console.WriteLine("Sayılar Eşit");
}


//loops 

//for,foreach,while,do-while

for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


for(int i = 0; i <= 20; i++)
{
    if(i%2==0)
        Console.WriteLine("Çift Sayılar " +  i);
    else
        Console.WriteLine("Tek Sayılar " + i);
}




//Console.Write("Bir sayı giriniz : ");
//int number = Convert.ToInt32(Console.ReadLine());
//int factorial = 1;

//for(int i = 1; i <= number; i++)
//{
//    factorial *= i; 
//}

//Console.WriteLine($"Factorial of {number} is {factorial}");



//arrays 

//int[] numbers = new int[3];
//numbers[0] = 30;
//numbers[1] = 60;
//numbers[2] = 90;

//for(int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine($"Element {i} : {numbers[i]}");
//}

int[] numbers = { 34, 67, 25, 46, 50 };
int max = numbers[0];
int min = numbers[0];

for(int i = 1; i < numbers.Length; i++)
{
    if (numbers[i]>max)
        max = numbers[i];
    if (numbers[i]<min)
        min = numbers[i];
}

Console.WriteLine($"Max : {max} , Min : {min}");

//List

//List<string> names = new List<string>();
//names.Add("Yunus Emre");
//names.Add("Mehmet Ali");
//names.Add("Kadriye");

//Console.WriteLine($"Selected Name : {names[0]}");

//foreach(string name in names)
//{
//    Console.WriteLine($" Name  : {name}");
//}



//List<string> names = new List<string>();
//Console.WriteLine("Enter names (type 'exit' to stop): ");
//while (true)
//{
//    Console.Write("Enter your name : ");
//    string name = Console.ReadLine();
//    if (name.ToLower() == "exit")
//        break;
//    names.Add(name);

//}

//Console.WriteLine("Names List:");
//foreach(string name in names)
//{
//    Console.WriteLine($"- {name} ");
//}




//OOP

//Product product = new Product();
//product.Name = "Laptop";
////product.UnitPrice = 5000;


//Product product2 = new Product();
//product2.Name = null;
////product2.UnitPrice = 5000;


//Console.WriteLine(product.Name);

////Console.WriteLine(product2.GetUnitPrice());

////Category category = new Category();
////category.Name = "Electronics";
////category.CreatedDate = DateTime.Now;

////Console.WriteLine(product.Id);
////Console.WriteLine(category.Name + " " + category.Id + " " + category.CreatedDate);


//CategoryManager categoryManager = new CategoryManager();
//List<Category> categories = categoryManager.GetCategories();

//foreach (var item in categories)
//{
//    Console.WriteLine(item.Name);
//}

//Console.WriteLine("**********");

//Category category1 = new Category();
//category1.Name = "Kozmetik";
//category1.CreatedDate = DateTime.Now;

//categoryManager.Add(category1);

//foreach (var item in categories)
//{
//    Console.WriteLine(item.Name);
//}











