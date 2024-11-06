using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Entitys
{
    public class Orders
    {
        public  int Id { get; set; }
        public  int CustomerId { get; set; }
        public int ProductId { get; set; }
        public  DateTime OrderDate { get; set; }
        public  int TotalAmount { get; set; }
    }
}
