using HW11.Dto;
using HW11.Entitys;
using HW11.Interfaces;
using HW11.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Services
{
    public class ProductsService
    {
        IProductsRepository productRep;
        public ProductsService()
        {
            productRep = new ProductsRepository();
        }
        public Result CreateProduct(Products product)
        {
            if (productRep.GetProduct(product.Id) == null)
            {
                productRep.CreateProduct(product);
                return new Result(true, "Product added successfully.");
            }
            else
                return new Result(false, "The product is already registered.");
         
        }
        public List<GetProductDto> GetAllProducts()
        {
            return productRep.GetAllProducts();
        }
        public GetProductDto GetProduct(int id)
        {
            if (productRep.GetProduct(id) != null)
            {
                return productRep.GetProduct(id);

            }
            else
                return null;
            
        }
        public Result UpdateProduct(Products product)
        {
            if (productRep.GetProduct(product.Id) != null)
            {
                productRep.UpdateProduct(product);
                return new Result(true, "Product Edited successfully.");
            }
            else
                return new Result(false, " product does not exist.");
            
          
        }
        public Result DeleteProduct(int id)
        {
            if (productRep.GetProduct(id) != null)
            {
                productRep.DeleteProduct(id);
                return new Result(true, "Product removed successfully.");
            }
            else
                return new Result(false, " product does not exist.");
           
        }
    }
}

