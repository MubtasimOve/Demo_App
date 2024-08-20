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
    }
}