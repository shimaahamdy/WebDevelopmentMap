using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_E.Areas.Finance.Controllers
{
    [HandleError(View = "ErrorFinance")]
    public class financesController : Controller
    {
        // GET: Finance/finances
        public ActionResult Index()
        {
            return View();
        }
    }
}