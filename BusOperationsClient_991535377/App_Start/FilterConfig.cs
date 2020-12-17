using System.Web;
using System.Web.Mvc;

namespace BusOperationsClient_991535377
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
