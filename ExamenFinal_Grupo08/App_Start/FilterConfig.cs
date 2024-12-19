using System.Web;
using System.Web.Mvc;

namespace ExamenFinal_Grupo08
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
