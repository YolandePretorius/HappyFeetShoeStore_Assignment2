﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HappyFeetShoeStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //for create to work properly
            routes.MapRoute(
                 name: "ProductsCreate",
                 url: "Products/Create",
                 defaults: new { controller = "Products", action = "Create" }
            );

            //route for paging on Category page
            routes.MapRoute(
                   name: "ProductsbyCategorybyPage",
                   url: "Products/{category}/Page{page}",
                    defaults: new { controller = "Products", action = "Index" }
            );

            //route for paging
            routes.MapRoute(
                name: "ProductsbyPage",
                 url: "Products/Page{page}",
                defaults: new { controller = "Products", action = "Index" }
            );

            routes.MapRoute(
                  name: "ProductsbyCategory",
                  url: "Products/{category}",
                  defaults: new { controller = "Products", action = "Index" }
            );

            routes.MapRoute(
                name: "ProductsIndex",
                url: "Products",
                defaults: new { controller = "Products", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
