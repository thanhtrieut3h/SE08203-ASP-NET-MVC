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
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // khong co loi
                string username = model.Username.ToString().Trim();
                string password = model.Password.ToString().Trim();
                if (username.Equals("trieunt") && password.Equals("12345"))
                {
                    // dang nhap thanh cong
                    // chuyen sang trang Dashboard
                    return RedirectToAction("Index", "Dashboard");
                }
                // thong bao dang nhap that bai
                ViewData["ErrorMessageLogin"] = "Your account invalid";
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
