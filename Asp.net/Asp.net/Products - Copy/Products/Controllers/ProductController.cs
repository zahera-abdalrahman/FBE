using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Models.Repositories;
using Products.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Products.ViewModel;

namespace Products.Controllers
{
    public class ProductController : Controller
    {
        public IRepository<Product> Products { get; }
        public IRepository<Category> Category { get; }
        public IHostingEnvironment Host { get; }

        public ProductController(IRepository<Product> products, IRepository<Category> category, IHostingEnvironment Host)
        {
            Products = products;
            Category = category;
            this.Host = Host;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            var data = Products.View();
            return View(data);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {

            var data = Products.Find(id);
            List<Product> products = new List<Product>();

            Product pr = new Product();
            pr.ProductId = data.ProductId;
            pr.ProductName = data.ProductName;
            pr.ProductPrice = data.ProductPrice;
            pr.ImageURL= data.ImageURL;
            pr.CategoryId = data.CategoryId;
            pr.Category = Category.Find(data.CategoryId);
            products.Add(pr);

            return View(pr);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {

            ViewBag.list = Category.View();
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel collection)
        {

            string ImageName = "";
            if (collection.File != null)
            {
                string PathImage = Path.Combine(Host.WebRootPath, "Images");
                FileInfo fi = new FileInfo(collection.File.FileName);
                ImageName = "Image" + DateTime.UtcNow.ToString().Replace("/", "").Replace(":", "").Replace("-", "").Replace(" ", "") + fi.Extension;
                string FullPath = Path.Combine(PathImage, ImageName);
                collection.File.CopyTo(new FileStream(FullPath, FileMode.Create));

            }


            try
            {
                Product obj = new Product
                {
                    ProductId = collection.ProductId,
                    ProductName = collection.ProductName,
                    ProductPrice = collection.ProductPrice,
                    CategoryId = collection.CategoryId,
                    ImageURL = ImageName
                };
                Products.Add(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {

            var data = Products.Find(id);
            List<ProductModel> products = new List<ProductModel>();

            ProductModel pr = new ProductModel();
            pr.ProductId = data.ProductId;
            pr.ProductName = data.ProductName;
            pr.ProductPrice = data.ProductPrice;
            pr.CategoryId = data.CategoryId;
            pr.Category = Category.Find(data.CategoryId);
            pr.ImageURL = data.ImageURL;

            ViewBag.list = Category.View();
            return View(pr);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductModel collection)
        {
            

            try
            {

                string ImageName = "";
                if (collection.File != null)
                {
                    string PathImage = Path.Combine(Host.WebRootPath, "Images");
                    FileInfo fi = new FileInfo(collection.File.FileName);
                    ImageName = "Image" + DateTime.UtcNow.ToString().Replace("/", "").Replace(":", "").Replace("-", "").Replace(" ", "") + fi.Extension;
                    string FullPath = Path.Combine(PathImage, ImageName);
                    collection.File.CopyTo(new FileStream(FullPath, FileMode.Create));
                }
                else
                {

                    //var  oldimage = Products.Find(id);
                    //  ImageName = oldimage.ImageURL;
                    ImageName = collection.ImageURL;

                }
                Product obj = new Product
                {
                    ProductId = collection.ProductId,
                    ProductName = collection.ProductName,
                    ProductPrice = collection.ProductPrice,
                    CategoryId = collection.CategoryId,
                    ImageURL = ImageName
                };

                Products.Update(id, obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Products.Find(id);
            List<Product> products = new List<Product>();

            Product pr = new Product();
            pr.ProductId = data.ProductId;
            pr.ProductName = data.ProductName;
            pr.ProductPrice = data.ProductPrice;
            pr.ImageURL= data.ImageURL;
            pr.CategoryId = data.CategoryId;
            pr.Category = Category.Find(data.CategoryId);
            products.Add(pr);
            return View(pr);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product collection)
        {
            try
            {
                Products.Delete(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
