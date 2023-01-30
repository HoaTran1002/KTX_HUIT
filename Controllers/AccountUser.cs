using Microsoft.AspNetCore.Mvc;

namespace KTX_Huit.Controllers
{
    public class AccountUser : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
