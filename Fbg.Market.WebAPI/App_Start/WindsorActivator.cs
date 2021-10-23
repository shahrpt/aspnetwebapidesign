using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBG.Market.WebAPI.App_Start
{
    public class WindsorActivator
    {
        static ContainerBootstrapper bootstrapper;

        public static void PreStart()
        {
            bootstrapper = ContainerBootstrapper.Bootstrap();
        }

        public static void Shutdown()
        {
            if (bootstrapper != null)
                bootstrapper.Dispose();
        }
    }
}