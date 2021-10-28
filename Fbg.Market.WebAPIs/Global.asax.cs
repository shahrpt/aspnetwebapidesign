using Fbg.Market.WebAPIs.MessageHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Fbg.Market.WebAPIs
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMap.AutoMap.RegisterMappings();
            GlobalConfiguration.Configuration.MessageHandlers.Add(new APIKeyHandler());
        }
    }
}
