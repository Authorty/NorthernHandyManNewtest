using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TheNorthernHandyManReDone11_3_18
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "About",
            url: "About-Me/About-my-business",
            defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "HomeIndex",
            url: "Landscaping-expertise",
            defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "HomeServices",
            url: "Services/Landscaping/Snow-Removal/Tree-Removal/Design-Build",
            defaults: new { controller = "Home", action = "Services", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Contact",
            url: "Contact/How-to-reach-us",
            defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "HomePhotos",
            url: "Photos/Examples-of-Landscaping",
            defaults: new { controller = "Home", action = "Albums", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "HomeVideos",
            url: "Videos/Operating-Equipment/In-Action",
            defaults: new { controller = "Home", action = "Videos", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "ServicesStormRelief",
            url: "Services/Storm-Relief-Services",
            defaults: new { controller = "Services", action = "StormRelief", id = UrlParameter.Optional }
            );
            ///
            routes.MapRoute(
            name: "ServicesSkidSteerWork",
            url: "Services/Skid-Steer-Work",
            defaults: new { controller = "Services", action = "SkidSteerWork", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "ServicesTreeRemoval",
            url: "Services/Tree-Removal",
            defaults: new { controller = "Services", action = "TreeRemoval", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "ServicesLandscapeMaintenance",
            url: "Services/Landscape-Maintenance-and-Lawn-Care",
            defaults: new { controller = "Services", action = "LandscapeMaintenance", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "ServicesLandscapeDesignBuild",
            url: "Services/Landscape-Design-Build",
            defaults: new { controller = "Services", action = "LandscapeDesignBuild", id = UrlParameter.Optional }
            );


            routes.MapRoute(
            name: "ServicesSnowRemoval",
            url: "Services/Snow-Removal",
            defaults: new { controller = "Services", action = "SnowRemoval", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
