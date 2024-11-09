using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public static  class Counfiguer
    {
        public static string Connectionstring { get; set; }
        static Counfiguer()
        {
            Connectionstring = @"Data Source=LEILI\LEILA;Initial Catalog=ShopDbE;Integrated Security=true; TrustServerCertificate=True";
        }
    }
}
