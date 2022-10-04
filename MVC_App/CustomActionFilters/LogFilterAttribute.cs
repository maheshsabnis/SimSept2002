using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_App.CustomActionFilters
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        private void LogRequest(string currntStatus, RouteData route)
        { 
            //1. REad the Controller Name
            string controller = route.Values["controller"].ToString();
            string action = route.Values["action"].ToString();
            string logMessage = $"Custeent statee of execcution is " +
                $"{currntStatus} in {controller} controller and its Actio Method as {action}";

            Debug.WriteLine(logMessage);

        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogRequest("OnActionExecuting", filterContext.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogRequest("OnActionExecuted", filterContext.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogRequest("OnResultExecuting", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            LogRequest("OnResultExecuted", filterContext.RouteData);
        }
    }
}