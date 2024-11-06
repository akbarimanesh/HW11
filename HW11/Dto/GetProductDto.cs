using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Dto
{
    public class GetProductDto
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public  int Price { get; set; }
        public  string CategoryName { get; set; }
    }
}
