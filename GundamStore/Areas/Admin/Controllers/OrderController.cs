using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Areas.Admin.Controllers
{
    [Area("admin")]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrderDetail()
        {
            return View();
        }
    }
}
