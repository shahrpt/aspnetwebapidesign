using Fbg.Market.Application;
using Fbg.Market.Infrastructure.Vendor;
using Fbg.Market.Repository.Product;
using Fbg.Market.Service.Product;
using Fbg.Market.Service.Vendor;
using Fbg.Market.WebAPIs.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace Fbg.Market.WebAPIs
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IVendorRepository, VendorRepository>();
            container.RegisterType<IVendorService, VendorService>();

            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IProductRepository, ProductRepository>();
            //container.RegisterType<IConfiguration, Configuration>();
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
               name: "swagger",
               routeTemplate: "",
               defaults: null,
               constraints: null,
               handler: new Swashbuckle.Application.RedirectHandler((message => message.RequestUri.ToString()), "swagger"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
