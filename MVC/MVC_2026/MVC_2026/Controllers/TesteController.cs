using Microsoft.AspNetCore.Mvc;

namespace MVC_2026.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Demo()
        {
            return View();
        }
    }
}
