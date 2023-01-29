using Microsoft.AspNetCore.Mvc;

namespace KTX_Huit.Areas.Admin.Controllers
{
    public class FloorController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
