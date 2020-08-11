using System.Web;
using System.Web.Mvc;

namespace ServicioBecarioV2._0Federado
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
