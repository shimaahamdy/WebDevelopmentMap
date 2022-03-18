using onException_HandleError.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onException_HandleError.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    //[Route("lecture")]
    [RoutePrefix("lecture")]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 30, VaryByParam = "x;y")]
        public string getCurrTime(int id, int x, int y)
        {
            return DateTime.Now.ToString();
        }

        [Route("~/test/MVC")]
        [myLogFilter]
        public ActionResult Index()
        {
            return View();
        }

        //[MyExceptionHandler(View = "myErrorPage")]
        //public ActionResult Index2()
        //{
        //    int a = 5;
        //    int b = 0;
        //    int c = 0;
        //    c = a / b; //it would cause exception.   

        //    return View();
        //}

        //[NonAction]
        [Route("")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("cc")]
        [ActionName("myContact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }
    }
}