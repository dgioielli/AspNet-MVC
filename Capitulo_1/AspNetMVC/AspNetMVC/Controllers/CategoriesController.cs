using AspNetMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMVC.Controllers
{
    public class CategoriesController : Controller
    {
        #region Variables and Properties

        private static IList<CategoryModel> categories = new List<CategoryModel>() {
            new CategoryModel() { CategoryId = 1, Name = "Notebooks" },
            new CategoryModel() { CategoryId = 2, Name = "Monitores" },
            new CategoryModel() { CategoryId = 3, Name = "Impressoras" },
            new CategoryModel() { CategoryId = 4, Name = "Mouses" },
            new CategoryModel() { CategoryId = 5, Name = "Desktops" },
        };

        #endregion

        #region Functions

        // GET
        public IActionResult Index()
        {
            return View(categories);
        }

        // GET: Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create (CategoryModel category)
        {
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            categories.Add(category);
            return RedirectToAction("Index");
        }

        // GET: Edit
        public IActionResult Edit(long id)
        {
            var category = categories.Where(x => x.CategoryId == id).First();
            return View(category);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryModel category)
        {
            categories.Remove(categories.Where(x => x.CategoryId == category.CategoryId).First());
            categories.Add(category);
            return RedirectToAction("Index");
        }

        // GET: Details
        public IActionResult Details(long id)
        {
            var category = categories.Where(x => x.CategoryId == id).First();
            return View(category);
        }

        // GET: Delete
        public IActionResult Delete(long id)
        {
            var category = categories.Where(x => x.CategoryId == id).First();
            return View(category);
        }

        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(CategoryModel category)
        {
            categories.Remove(categories.Where(x => x.CategoryId == category.CategoryId).First());
            return RedirectToAction("Index");
        }


        #endregion
    }
}
