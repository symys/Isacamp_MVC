using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kategoriMvc.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public bool isDeleteP { get; set; }
        //public Category Category { get; set; }

    }
}
