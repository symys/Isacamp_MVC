using kategoriMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace kategoriMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CategoryProductModel model = new CategoryProductModel();

            model.Products = ProductManagementDB.ProductList;
            model.Categories = ProductManagementDB.CategoryList ;
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            var categoryControl = ProductManagementDB.CategoryList.FirstOrDefault(x => x.Id == category.Id);
            //yukarıdaki sorgudan username kontrolu yapılıyor
            //eger formdan gelen username DB de yoksa ekleme yapılacak
            if (categoryControl == null)    
            {
                ProductManagementDB.AddCategory(category);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.mesaj = "bu kategori sistemde mevcut zaten :)";
            }
            return View();
        }


        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            var productControl = ProductManagementDB.ProductList.FirstOrDefault(x => x.ProductId == product.ProductId);

            if (productControl == null)
            {
                ProductManagementDB.AddProduct(product);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.mesaj = "bu ürün sistemde mevcut zaten :)";
            }
            return View();
        }


        public IActionResult DeleteCategory(int Id)
        {
                var categoryControl = ProductManagementDB.CategoryList.FirstOrDefault(x => x.Id == Id);
                if (categoryControl != null)
                {
                    ProductManagementDB.DeleteCategory(categoryControl);

                }
            return RedirectToAction("Index");
            return View();

        }

        public IActionResult DeleteProduct(int Id)
        {
            var productControl = ProductManagementDB.ProductList.FirstOrDefault(x => x.ProductId == Id);
            if (productControl != null)
            {
                ProductManagementDB.DeleteProduct(productControl);

            }
            return RedirectToAction("Index");
            return View();

        }

        [HttpGet]
        public IActionResult EditCategory(int Id)
        {
            var categoryControl = ProductManagementDB.CategoryList.FirstOrDefault(x => x.Id == Id);
            if (categoryControl == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(categoryControl);
            }

        }

        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            ProductManagementDB.EditCategory(category);
            return RedirectToAction("Index");
            //return Redirect(Request.Headers["Referer"].ToString());
        }


        [HttpGet]
        public IActionResult EditProduct(int Id)
        {
            var productControl = ProductManagementDB.ProductList.FirstOrDefault(x => x.ProductId == Id);
            if (productControl == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(productControl);
            }

        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            ProductManagementDB.EditProduct(product);
            return RedirectToAction("Index");
        }

    }
}
