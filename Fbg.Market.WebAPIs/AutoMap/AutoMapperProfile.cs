using AutoMapper;
using Fbg.Market.DbModel.Model;
using Fbg.Market.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fbg.Market.WebAPIs.AutoMap
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<CreateProductModel, Product>();
            CreateMap<UpdateProductModel, Product>();
        }
    }
}