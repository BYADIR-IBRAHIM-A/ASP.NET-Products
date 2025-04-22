using Microsoft.AspNetCore.Mvc;
using Products.Models;

namespace Products.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<ProductModel>
            {
                new ProductModel { Id = 1, Name = "هور الفلوكس الوردي", Price = 22, ImagePath = "flower1.jpg" },
                new ProductModel { Id = 2, Name = "زهرة الجوري", Price = 19, ImagePath = "flower2.jpg" },
                new ProductModel { Id = 3, Name = "ورود بيضاء", Price = 20, ImagePath = "flower3.jpg" }
            };
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = new ProductModel { Id = id, Name = "مشروب ماتشا لاتيه", Price = 22 };
            return View(product);
        }

        public IActionResult Random()
        {
            var product = new ProductModel { Id = 1, Name = "مشروب ماتشا لاتيه", Price = 19 };
            return View(product);
        }
    }
}