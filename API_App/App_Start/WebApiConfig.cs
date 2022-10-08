using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API_App
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Enablin Cross Origin Resource Sharing
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();
            // Routing For the API
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
