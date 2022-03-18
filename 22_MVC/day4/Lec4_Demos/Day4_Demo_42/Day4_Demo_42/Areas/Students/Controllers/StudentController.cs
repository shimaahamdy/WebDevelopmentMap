using System;
using System.Web.Mvc;

namespace Day4_Demo_42.Areas.Students.Controllers
{
    //[HandleError(View = "myErrorpage", ExceptionType = typeof(DivideByZeroException))]
    //[HandleError(View = "Error222", ExceptionType = typeof(ArgumentNullException))]
    //[HandleError(View = "Error", ExceptionType = typeof(ArgumentOutOfRangeException))]

    [HandleError(View = "myErrorpage")]
    public class StudentController : Controller
    {
        // GET: Students/Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult test2()
        {
            string str = "yyyyyy";
            int num = Convert.ToInt32(str);  //Error

            return View();
        }

        [HandleError(View = "Error")]
        public ActionResult test3()
        {
            throw new Exception();
        }
    }

    // HttpRequest ===>
    // HttpResponse ( Body, StatusCode, )
    // HandleErrorInfo

}