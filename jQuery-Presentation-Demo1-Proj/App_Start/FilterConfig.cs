using System.Web;
using System.Web.Mvc;

namespace jQuery_Presentation_Demo1_Proj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
