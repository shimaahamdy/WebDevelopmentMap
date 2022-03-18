using System.Web.Mvc;

namespace Day5_Demo_42
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AuthorizeAttribute());

            filters.Add(new HandleErrorAttribute());
        }
    }
}
