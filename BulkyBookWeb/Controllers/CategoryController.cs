using BulkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
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
            var ObjCategoryList = _db.categories.ToList();
            return View();
        }
    }
}
