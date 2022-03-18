using Day5_Demo_42.Models;
using System;
using System.Web.Mvc;

namespace Day5_Demo_42.Controllers
{
    //[Authorize(Roles = "Admin; Hr")]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 30, VaryByParam = "x;y")]
        public string getCurTime(int x, int y, int z)
        {
            return DateTime.Now.ToString();
        }

        //[myLogFilter]
        public ActionResult Index()
        {
            return View();
        }

        //[MyExceptionHandler(View = "myErrorPage")]
        [MyExceptionHandler]
        public ActionResult Index2()
        {
            int a = 5;
            int b = 0;
            int c = 0;
            c = a / b; //it would cause exception.   

            return View();
        }

        //[NonAction]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ActionName("myContact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }
    }
}