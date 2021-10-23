using AutoMapper;
using Fbg.Market.DbModel.Model;
using Fbg.Market.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fbg.Market.WebAPIs.App_Start
{
    public class AutoMapperConfig
    {
        public AutoMapperConfig()
        {
           
        }
        public static MapperConfiguration MapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CreateProductModel, Product>();

            });
            return configuration;
        }
    }
}