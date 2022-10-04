using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_App.CustomActionFilters
{
    public class CustomExceptionFilterAttribute : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            // 1. Set the Exception As Handleed so that the request Procesing will be stopped
            filterContext.ExceptionHandled = true;
            // 2. Get the Exception Object
            Exception ex = filterContext.Exception;

            // 3. Set the ViewResult
            ViewResult result = new ViewResult();
            result.ViewName = "Error";
            // 3.a. Create a ViewDataDictionary to pass data to View
            var viewData = new ViewDataDictionary();
            viewData["ExceptionMessage"] = ex.Message;
            RouteData route = filterContext.RouteData;
            viewData["ControllerName"] = route.Values["controller"].ToString();
            viewData["ActionName"] = route.Values["action"].ToString();
            // 3.b. Pass teh ViewData to the ViewData proeprty of the ViewResult classs
            result.ViewData = viewData;
            // 4. Set the Result
            filterContext.Result = result;
        }
    }
}