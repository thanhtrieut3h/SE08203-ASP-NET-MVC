using Microsoft.AspNetCore.Mvc;
using SIMS.Models;

namespace SIMS.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // khong co loi
                string username = model.Username.ToString().Trim();
                string password = model.Password.ToString().Trim();
                return Ok(username + " --- " + password);
            }
            return View(model);
        }
    }
}
