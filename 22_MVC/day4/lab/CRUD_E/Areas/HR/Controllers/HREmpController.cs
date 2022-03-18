using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_E.Areas.HR.Controllers
{
    [HandleError(View = "ErrorHR")]
    public class HREmpController : Controller
    {
        // GET: HR/HREmp
        public ActionResult Index()
        {
            string x = null;
            int y = x.Length;
            return View();
        }
    }
}