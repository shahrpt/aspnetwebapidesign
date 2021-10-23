using AutoMapper;
using Fbg.Market.Application;
using Fbg.Market.DbModel.Model;
using Fbg.Market.Infrastructure.Vendor;
using Fbg.Market.Models.Product;
using Fbg.Market.Repository.Product;
using Fbg.Market.Service.Product;
using Fbg.Market.Service.Vendor;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Fbg.Market.WebAPIs
{
    public static class UnityConfig
    {
        /*public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IVendorRepository, VendorRepository>();
            container.RegisterType<IVendorService, VendorService>();
           
            //container.RegisterType<IProductService, ProductService>();
            //container.RegisterType<IProductRepository, ProductRepository>();
            //container.RegisterType<IMapper, Mapper>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }*/
    }
}