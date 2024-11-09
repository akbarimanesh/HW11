using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Entitys
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
             
       // public  string ? CategoryName { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
    }
}
