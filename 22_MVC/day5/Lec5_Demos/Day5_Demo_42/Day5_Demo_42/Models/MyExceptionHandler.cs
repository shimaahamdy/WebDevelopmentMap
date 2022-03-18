using System;
using System.Web.Mvc;

namespace Day5_Demo_42.Models
{
    public class MyExceptionHandler : HandleErrorAttribute //FilterAttribute, IExceptionFilter
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //if(filterContext.ExceptionHandled || filterContext.HttpContext.IsCustomErrorEnabled == true)
            //{
            //}

            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "IDError"
            };

            base.OnException(filterContext);
        }
    }
}
