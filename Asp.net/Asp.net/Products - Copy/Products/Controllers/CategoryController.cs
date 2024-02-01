using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Models.Repositories;
using Products.Models;
using Products.ViewModel;
using System;
using System.IO;

namespace Products.Controllers
{
    public class CategoryController : Controller
    {
        public IRepository<Category> Category { get; }
        public IWebHostEnvironment Host { get; }

        public CategoryController(IRepository<Category> _Category, IWebHostEnvironment Host)
        {
            Category = _Category;
        }
        // GET: CategoryController
        public ActionResult Index()
        {

            return View(Category.View());
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View(Category.Find(id));
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryModel collection, [FromServices] IWebHostEnvironment host)
        {
            
            try
            {
                string ImageName = "";
                if (collection.File != null)
                {
                    string PathImage = Path.Combine(host.WebRootPath, "Images");
                    FileInfo fi = new FileInfo(collection.File.FileName);
                    ImageName = "Image" + DateTime.UtcNow.ToString().Replace("/", "").Replace(":", "").Replace("-", "").Replace(" ", "") + fi.Extension;
                    string FullPath = Path.Combine(PathImage, ImageName);
                    collection.File.CopyTo(new FileStream(FullPath, FileMode.Create));
                }
                Category obj = new Category
                {
                    CategoryId = collection.CategoryId,
                    CategoryName = collection.CategoryName,
                    ImageURL = ImageName
                };

                Category.Add(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Category.Find(id);
            CategoryModel cat=new CategoryModel();
            cat.CategoryId=data.CategoryId;
            cat.CategoryName=data.CategoryName;
            cat.ImageURL=data.ImageURL;
            return View(cat);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,CategoryModel collection, [FromServices] IWebHostEnvironment host)
        {
            
            try
            {
                string ImageName = "";
                if (collection.File != null)
                {
                    string PathImage = Path.Combine(host.WebRootPath, "Images");
                    FileInfo fi = new FileInfo(collection.File.FileName);
                    ImageName = "Image" + DateTime.UtcNow.ToString().Replace("/", "").Replace(":", "").Replace("-", "").Replace(" ", "") + fi.Extension;
                    string FullPath = Path.Combine(PathImage, ImageName);
                    collection.File.CopyTo(new FileStream(FullPath, FileMode.Create));
                }
                else
                {
                    //  ImageName = oldimage.ImageURL;
                    ImageName = collection.ImageURL;

                }

                Category obj = new Category
                {
                    CategoryId = collection.CategoryId,
                    CategoryName = collection.CategoryName,
                    ImageURL = ImageName
                };

                Category.Update(id, obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Category.Find(id));
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category collection)
        {
            try
            {

                Category.Delete(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
