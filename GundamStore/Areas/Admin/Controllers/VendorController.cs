using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Areas.Admin.Controllers
{
    [Area("admin")]
    public class VendorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
