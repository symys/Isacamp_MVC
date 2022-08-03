using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kategoriMvc.Models
{
    public class ProductManagementDB
    {
        private static List<Category> _categorylist;
        private static List<Product> _productlist;

        static ProductManagementDB()
        {
            _categorylist = new List<Category>()
            {
               
            };

            _productlist = new List<Product>()
            {
               
            };
        }

        public static List<Product> ProductList
        {
            get { return _productlist; }
        }

        public static List<Category> CategoryList
        {
            get { return _categorylist; }
        }

        public static void AddCategory(Category category)
        {
            _categorylist.Add(category);
        }
        
        public static void AddProduct(Product product)
        {
            _productlist.Add(product);
        }

        public static void EditCategory(Category category)
        {
            var categoryEdit = _categorylist.FirstOrDefault(x => x.Id == category.Id);
            categoryEdit.CategoryName = category.CategoryName;
        } 
        
        public static void EditProduct(Product product)
        {
            var productEdit = _productlist.FirstOrDefault(x => x.ProductId == product.ProductId);
            productEdit.CategoryId = product.CategoryId;
            productEdit.ProductName = product.ProductName;
        }

        public static void DeleteCategory(Category category)
        {
            if(category.isDeleteC == false)
            {
                category.isDeleteC = true;
            }
            //_categorylist.Remove(category);
        }

        public static void DeleteProduct(Product product)
        {
            if (product.isDeleteP == false)
            {
                product.isDeleteP = true;
            }
            //_categorylist.Remove(category);
        }
    }
}
