using System.Web;
using System.Web.Mvc;

namespace onException_HandleError
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new AuthorizeAttribute());
            filters.Add(new HandleErrorAttribute());

        }
    }
}
