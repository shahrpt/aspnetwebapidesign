﻿using Castle.MicroKernel.Registration;
using Fbg.Market.Service.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBG.Market.WebAPI.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
                 Component
                 .For<IProductService>()
                 .ImplementedBy<ProductService>()
                 .LifestyleSingleton());
        }
    }
}