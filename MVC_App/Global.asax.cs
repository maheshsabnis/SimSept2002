using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC_App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //1. Load the MVC Algorithm for Understand the Location of
            // Controllers and View
            AreaRegistration.RegisterAllAreas();
            // 2. Register all Action Filters (Custom Logic for Logging, Exception, Security, ect.)
            // At the Application level
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            // 3. CReate a Route Table for Controllers and its Action Methods
            // SO that it will be easy for End-User to Request
            // Controller and its action method
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // 4. Creating a Bundle for JavaScript Apps 
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
