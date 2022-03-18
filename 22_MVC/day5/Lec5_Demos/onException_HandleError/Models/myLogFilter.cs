using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onException_HandleError.Models
{
    public class myLogFilter: ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("OnActionExecuted Log: " +
                "Action: " + filterContext.RouteData.Values["action"] +
                ", Controller: " + filterContext.RouteData.Values["controller"]);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("OnResultExecuted Log: " +
          "HttpMethod: " + filterContext.HttpContext.Request.HttpMethod +
          " Action: " + filterContext.RouteData.Values["action"] +
          ", Controller: " + filterContext.Controller);
        }
    }
}