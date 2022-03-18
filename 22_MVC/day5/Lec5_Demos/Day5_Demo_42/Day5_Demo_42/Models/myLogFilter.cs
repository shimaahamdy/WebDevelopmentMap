using System.Diagnostics;
using System.Web.Mvc;

namespace Day5_Demo_42.Models
{
    public class myLogFilter : ActionFilterAttribute
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