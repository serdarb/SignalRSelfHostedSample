﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace POC.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}