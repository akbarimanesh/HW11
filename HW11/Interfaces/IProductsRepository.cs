using HW11.Dto;
using HW11.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Interfaces
{
    public interface IProductsRepository
    {
        public void CreateProduct(Products product);
        public List<GetProductDto> GetAllProducts();
        public GetProductDto GetProduct(int id);
        public void UpdateProduct(Products product);
        public void DeleteProduct(int id);

    }
}
