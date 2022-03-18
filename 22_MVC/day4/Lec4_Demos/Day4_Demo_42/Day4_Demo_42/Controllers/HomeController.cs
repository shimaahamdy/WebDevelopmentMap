using System.Web.Mvc;

namespace Day4_Demo_42.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult testFun()
        {
            //try
            //{
            string str = null;
            ViewBag.msg = str.Length;  //Error

            return View();
            //}
            //catch
            //{
            //    return View("Error");
            //}
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}