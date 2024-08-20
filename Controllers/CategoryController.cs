using Demo_App.Data;
using Demo_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace Demo_App.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString() )
            {
                ModelState.AddModelError("name","The display Order can not exactly match the name. ");
            
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();   

        }
        public IActionResult Edit(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }

            Category categoryfromDb = _db.Categories.Find(id);
            if (categoryfromDb == null)
            {
                return NotFound();
            }
             return View(categoryfromDb);

        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category categoryfromDb = _db.Categories.Find(id);
            if (categoryfromDb == null)
            {
                return NotFound();
            }
            return View(categoryfromDb);

        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

           
            return View();

        }


    }
}