using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExerciseFromVideos
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.academy/{*pathInfo}"); // ne obrabotva link sys academy v nego

            routes.LowercaseUrls = true;

            //routes.MapRoute(
            //    name: "ProbenTochen",
            //    url: "tochenadress/trqbvadavlezne",
            //    defaults: new { controller = "Users", action = "StringMethod", id = UrlParameter.Optional });

            //routes.MapRoute(
            //    name: "ProbenControllerVKraq",
            //    url: "tochenadress/trqbvadavlezne/{controller}",
            //    defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional });

            //routes.MapRoute(
            //    name: "ProbenControllerVSredata",
            //    url: "tochenadress/trqbvadavlezne/{controller}/neshto",
            //    defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional });

            //routes.MapRoute(
            //    name: "ProbenControllerVSredataIVNachaloto",
            //    url: "{action}/tochenadress/trqbvadavlezne/{controller}/neshto",
            //    defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "EnteredDate",
                url: "{day}/{month}/{year}",
                defaults: new { controller = "Users", action = "DateTime" },
                constraints: new { day=@"\d{2}", month=@"\d{2}", year =@"\d{4}"});

            routes.MapRoute(
                name: "ActionResultStringMethod",
                url: "{controller}/{action}/{firstNumber}/{secondNumber}/{name}",
                defaults: new { controller = "Users", action = "StringMethod", secondNumber = UrlParameter.Optional, name = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
