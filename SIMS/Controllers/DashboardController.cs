using Microsoft.AspNetCore.Mvc;
using SIMS.Models;

namespace SIMS.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewData["name"] = "Thanh Trieu";
            ViewData["age"] = 20;
            ViewData["address"] = "Ha Noi";
            var product = new ProductViewModel { Id = 1, Name = "Iphone", Price = 1500.86f };

            return View(product);
        }
    }
}
