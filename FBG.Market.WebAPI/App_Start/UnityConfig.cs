using Fbg.Market.Service.Product;
using System.Web.Http;
using System.Web.Mvc;

namespace FBG.Market.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			// register all your components with the container here
            // it is NOT necessary to register your controllers

           //container.RegisterType<IProductService, ProductService>();

            // Configures container for ASP.NET MVC
            //DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            // Configures container for WebAPI
            //GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}