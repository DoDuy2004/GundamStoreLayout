using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SubCategory() { 
            return View();
        }
    }
}
