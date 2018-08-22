using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "search",
                url: "path/search/{action}",
                defaults: new { controller = "Search", action = "Result", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "search-details",
                url: "word/{id}",
                defaults: new { controller = "Search", action = "Details", id =  UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "home",
                url: "path/home/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
