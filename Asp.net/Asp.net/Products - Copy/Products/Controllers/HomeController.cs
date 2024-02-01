using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products.Models;
using Products.Models.Repositories;
using Products.ViewModel;
using System.Diagnostics;

namespace Products.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IRepository<Category> Category { get;}

        public IRepository<Product> Product { get; }
        public HomeController(ILogger<HomeController> logger,IRepository<Category> _Category, IRepository<Product> _product)
        {
            _logger = logger;
            Category = _Category;
            Product = _product;
        }

        public IActionResult Index()
        {
            HomeModel model = new HomeModel
            {
                CategoryList=Category.View().ToList(),
            };

            return View(model);
        }

        public IActionResult Products(string categoryName)
        {
            HomeModel model;

            if (!string.IsNullOrEmpty(categoryName))
            {
                // Filter products by category
                model = new HomeModel
                {
                    ProductList = Product
                        .View()
                        .Where(p => p.Category.CategoryName == categoryName)
                        .ToList(),
                };
            }
            else
            {
                // If no category is selected, show all products
                model = new HomeModel
                {
                    ProductList = Product.View().ToList(),
                };
            }

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
    }
}