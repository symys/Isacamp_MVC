﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kategoriMvc.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool isDeleteC { get; set; }
        //public List<Product> Products { get; set; }
    }
}
