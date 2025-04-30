using Microsoft.AspNetCore.Mvc;

namespace EDgecut.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
