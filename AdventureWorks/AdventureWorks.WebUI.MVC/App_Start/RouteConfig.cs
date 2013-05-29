﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AdventureWorks.WebUI.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new {controller = "Employee", action = "Details"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new {controller = "Employee", action = "Details"}
                );
        }
    }
}