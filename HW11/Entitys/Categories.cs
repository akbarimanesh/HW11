﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Entitys
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Products> Products { get; set; }

    }
}
