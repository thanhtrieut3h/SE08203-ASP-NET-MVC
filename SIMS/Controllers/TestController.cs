using Microsoft.AspNetCore.Mvc;

namespace SIMS.Controllers
{
    public class TestController : LoginController
    {
        public string Index()
        {
            return "Test project";
        }
        public string Demo()
        {
            return "Demo project";
        }
        public IActionResult Login()
        {
            return View(); // lam viec voi view
        }
    }
}
