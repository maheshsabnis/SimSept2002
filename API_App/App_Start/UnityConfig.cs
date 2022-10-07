using System.Web.Http;
using Unity;
using Unity.WebApi;
using Application.Data.Contract;
using Application.Model.Entities;
using Application.Data.DataAccess.Services;
namespace API_App
{
    // Register All Dependencies
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
             container.RegisterType<IDbAccess<Category,int>, CategoryDataAccessService>();
             container.RegisterType<IDbAccess<Product,int>, ProductDataAccessService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}