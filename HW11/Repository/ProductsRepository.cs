using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using HW11.Interfaces;
using HW11.Entitys;
using Colors.Net;
using System.Data;
using HW11.Querys;
using System.Xml.Linq;
using System.Diagnostics;
using HW11.Dto;

namespace HW11.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        public void CreateProduct(Products product)
        {
            using (IDbConnection con = new SqlConnection(Counfiguer.Connectionstring))
            {
                con.Execute(QuerysShopdb.CreateProduct, new { Name = product.Name, CategoryId = product.CategoriesId, Price = product.Price });

            }

        }


        public void DeleteProduct(int id)
        {
            using (IDbConnection con = new SqlConnection(Counfiguer.Connectionstring))
            {
                con.Execute(QuerysShopdb.DeleteProduct, new { Id = id });

            }
        }

        public GetProductDto GetProduct(int id)
        {
            using (IDbConnection con = new SqlConnection(Counfiguer.Connectionstring))
            {
                return con.QueryFirstOrDefault<GetProductDto>(QuerysShopdb.GetProductById, new { Id = id });
              
            }
           
        }

        public List<GetProductDto> GetAllProducts()
        {
            using (IDbConnection con = new SqlConnection(Counfiguer.Connectionstring))
            {
                return con.Query<GetProductDto>(QuerysShopdb.GetAllProduct).ToList();

            }
           
        }

        public void UpdateProduct(Products product)
        {
            using (IDbConnection con = new SqlConnection(Counfiguer.Connectionstring))
            {
                con.Execute(QuerysShopdb.UpdateProduct, new {Id=product.Id, Name=product.Name, CategoryId=product.CategoriesId, Price=product.Price });

            }
        }
    }
}
