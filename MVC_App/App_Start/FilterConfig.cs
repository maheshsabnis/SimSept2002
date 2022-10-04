using System.Web;
using System.Web.Mvc;
using MVC_App.CustomActionFilters;
namespace MVC_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // Register the Global Filter
            filters.Add(new LogFilterAttribute());
            // Register ExceptionFilter at controller Level
            filters.Add(new CustomExceptionFilterAttribute());
        }
    }
}
