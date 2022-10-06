using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_App.Startup))]
namespace MVC_App
{
    public partial class Startup
    {
        /// <summary>
        ///  Provide OWIN Integration for USer and Role Based Authentication
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
