using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kategoriMvc.Models
{
    public class CategoryProductModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
