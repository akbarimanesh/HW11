using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Querys
{
    public static class QuerysShopdb
    {
        public static string CreateProduct = "INSERT INTO Products(Name,CategoryId,Price)VALUES(@Name,@CategoryId,@Price);";
        public static string GetAllProduct = "SELECT p.Id, p.Name,p.CategoryId,p.Price,c.name AS CategoryName FROM Products AS p INNER JOIN Categories AS c ON c.Id = p.CategoryId;";
        public static string GetProductById = "SELECT p.Id, p.Name,p.Price,c.name AS CategoryName FROM Products AS p INNER JOIN Categories AS c ON c.Id = p.CategoryId WHERE p.id=@Id;";
        public static string UpdateProduct = "UPDATE Products set  Name=@Name,CategoryId=@CategoryId,Price=@Price WHERE Id=@Id;";
        public static string DeleteProduct = "DELETE Products WHERE Id=@Id;";
    }
}
