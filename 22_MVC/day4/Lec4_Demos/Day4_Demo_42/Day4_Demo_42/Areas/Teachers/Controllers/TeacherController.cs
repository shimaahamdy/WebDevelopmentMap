using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4_Demo_42.Areas.Teachers.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teachers/Teacher
        public ActionResult Index()
        {
            return View();
        }
    }
}