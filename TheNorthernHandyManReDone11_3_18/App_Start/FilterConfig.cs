using System.Web;
using System.Web.Mvc;

namespace TheNorthernHandyManReDone11_3_18
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
