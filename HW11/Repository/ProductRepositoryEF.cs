using HW11.Dto;
using HW11.Entitys;
using HW11.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Repository
{
    public class ProductRepositoryEF : IProductsRepository
    {
        private readonly AppDbContext appDbContext;
        public ProductRepositoryEF()
        {
            appDbContext = new AppDbContext();
        }
        public void CreateProduct(Products product)
        {
            appDbContext.products.Add(product);
            appDbContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            appDbContext.products.Remove(appDbContext.products.Find(id));
            appDbContext.SaveChanges();
        }

        public List<GetProductDto> GetAllProducts()
        {
            return appDbContext.products
                .Select(x => new GetProductDto()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                CategoryName = x.Categories.Name
            }).ToList();
        }

        public GetProductDto GetProduct(int id)
        {
            return appDbContext.products.Where(x=> x.Id == id)
                .Select(x => new GetProductDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    CategoryName = x.Categories.Name
                }).FirstOrDefault();
        }

        public void UpdateProduct(Products product1)
        {
           var product= appDbContext.products.FirstOrDefault(p => p.Id == product1.Id);
            product.Name = product1.Name;
            product.Price = product1.Price;
            product.CategoriesId = product1.CategoriesId;
            appDbContext.SaveChanges();
        }
    }
}
