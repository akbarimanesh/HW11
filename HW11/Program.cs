using HW11.Entitys;
using HW11.Services;
using static Colors.Net.StringStaticMethods;
using Dapper;
using System.Data.SqlClient;
using Colors.Net;
using HW11;
using ConsoleTables;
using System.Numerics;
using HW11.Dto;

ProductsService productsService = new ProductsService();
Products products = new Products();
int option;
while (true)
{
    try
    {

        do
        {


            Console.Clear();
            ColoredConsole.WriteLine($"{White("1:Create a new product ")}");
            ColoredConsole.WriteLine($"{White("2:Show product list ")}");
            ColoredConsole.WriteLine($"{White("3:Show product by id ")}");
            ColoredConsole.WriteLine($"{White("4:Edit product details ")}");
            ColoredConsole.WriteLine($"{White("5:Deleted product ")}");
            ColoredConsole.WriteLine($"{Yellow("******************************")}");
            ColoredConsole.Write($"{Blue("please Enter your option :")}");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CreateProduct();
                    break;
                case 2:
                    GetallProduct();
                    break;
                case 3:
                    Getproductbyid();
                    break;
                case 4:
                    Updateproduct();
                    break;
                case 5:
                    Deleteproduct();
                    break;
                default:
                    break;
            }


        } while (option < 6);

    }
    catch (Exception ex)
    {
        ColoredConsole.WriteLine($"{Red("Select an option.")}");

    }
    Console.ReadKey();
}



void CreateProduct()
{
    try
    {
        Console.Clear();
        ColoredConsole.Write($"{Blue("Please Enter Name :")}");
        string name = Console.ReadLine();
        ColoredConsole.Write($"{Blue("Please Enter CategoryId :")}");
        int categoryid = int.Parse(Console.ReadLine());
        ColoredConsole.Write($"{Blue("Please Enter Price :")}");
        int price = int.Parse(Console.ReadLine());
        products.Name = name;
        products.CategoriesId = categoryid;
        products.Price = price;
        var result = productsService.CreateProduct(products);
        if (result.Isuccess)
        {
            ColoredConsole.WriteLine($"{Yellow("******************************")}");
            ColoredConsole.WriteLine($"{Green(result.Massege)}");

            Console.ReadKey();

        }
        else
        {
            ColoredConsole.WriteLine($"{Yellow("******************************")}");
            ColoredConsole.WriteLine($"{Red(result.Massege)}");


            Console.ReadKey();
        }
    }
    catch(Exception ex)
    {
        ColoredConsole.WriteLine($"{Red("Please complete the form.")}");

        Console.ReadKey();



    }
    

    Console.ReadKey();
}
void GetallProduct()
{
    Console.Clear();
    var products2=productsService.GetAllProducts();
    ConsoleTable.From<GetProductDto>(products2)
        .Configure(o => o.NumberAlignment = Alignment.Right)
        .Write(Format.Minimal);
    Console.ReadKey();

}
void Getproductbyid()
{
    try
    {
        Console.Clear();
        GetallProduct();
        ColoredConsole.WriteLine($"{Yellow("****************************************************")}");
        Console.Write("Please Enter Id :");
        int id = int.Parse(Console.ReadLine());
        var products1 = productsService.GetProduct(id);
        if (products1 != null)
        {
           
             Console.WriteLine($"Id= {products1.Id} / Name= {products1.Name} / price={products1.Price} / categoryName={products1.CategoryName} ");
        }
        else
            ColoredConsole.WriteLine($"{Red("product does not exist")}");
       
    }
    catch(Exception ex)
    {
        ColoredConsole.WriteLine($"{Red("Select an product.")}");
    }
    Console.ReadKey();
}
void Updateproduct()
{
    try
    {
        Console.Clear();
        GetallProduct();
        ColoredConsole.WriteLine($"{Yellow("*********************************************")}");
        ColoredConsole.Write($"{Blue("Please Enter Id :")}");
        int id = int.Parse(Console.ReadLine());
        ColoredConsole.Write($"{Blue("Please Enter Name :")}");
        string name = Console.ReadLine();
        ColoredConsole.Write($"{Blue("Please Enter CategoryId :")}");
        int categoryid = int.Parse(Console.ReadLine());
        ColoredConsole.Write($"{Blue("Please Enter Price :")}");
        int price = int.Parse(Console.ReadLine());
        products.Id = id;
        products.Name = name;
        products.CategoriesId = categoryid;
        products.Price = price;
        var result = productsService.UpdateProduct(products);
        if (result.Isuccess)
        {
            ColoredConsole.WriteLine($"{Yellow("******************************")}");
            ColoredConsole.WriteLine($"{Green(result.Massege)}");

            Console.ReadKey();

        }
        else
        {
            ColoredConsole.WriteLine($"{Yellow("******************************")}");
            ColoredConsole.WriteLine($"{Red(result.Massege)}");

            Console.ReadKey();
        }
        
    }
    catch(Exception ex)
    {
        ColoredConsole.WriteLine($"{Red("Select an product.")}");
       
    }
    
    Console.ReadKey();
}
void Deleteproduct()
{
    try
    {
        Console.Clear();
        GetallProduct();
        ColoredConsole.WriteLine($"{Yellow("********************************************")}");
        Console.Write("Please Enter Id :");
        int id = int.Parse(Console.ReadLine());
        var result = productsService.DeleteProduct(id);
        if (result.Isuccess)
        {
            ColoredConsole.WriteLine($"{Yellow("******************************")}");
            ColoredConsole.WriteLine($"{Green(result.Massege)}");

            Console.ReadKey();

        }
        else
        {

            ColoredConsole.WriteLine($"{Red(result.Massege)}");

            Console.ReadKey();
        }
    }
    catch(Exception ex)
    {
        
        ColoredConsole.WriteLine($"{Red("Select an product.")}");
    }
   
    Console.ReadKey();
}