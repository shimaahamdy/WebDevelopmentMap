using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ShowDetails(int ID, string Name, string image)
        {
            ViewBag.ID = ID;
            ViewBag.Name = Name;
            ViewBag.Image = image;
            return View();

        }
        public ActionResult Home()
        {
            return View();
        }
        
    }
}