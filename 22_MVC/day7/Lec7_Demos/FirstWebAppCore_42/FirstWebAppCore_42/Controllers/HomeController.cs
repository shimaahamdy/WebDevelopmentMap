using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppCore_42.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
