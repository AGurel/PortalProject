﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PortalProject.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "PageDetail",
                url: "sayfa/{title}/{pageId}",
                defaults: new { controller = "Page", action = "PageDetail" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
                name: "ProductDetail",
                url: "urun/{title}/{productId}",
                defaults: new { controller = "Product", action = "ProductDetail" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
                name: "ProServiceDetail",
                url: "hizmetler/{title}/{proServiceId}",
                defaults: new { controller = "ProService", action = "ProServiceDetail" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
                name: "NewsDetail",
                url: "haberler/{title}/{newsId}",
                defaults: new { controller = "News", action = "NewsDetail" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
                name: "SSSDetail",
                url: "sss/{title}/{faqId}",
                defaults: new { controller = "Faq", action = "FaqDetail" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
                name: "SSS",
                url: "sss",
                defaults: new { controller = "Faq", action = "Faq" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
                name: "News",
                url: "haberler",
                defaults: new { controller = "News", action = "News" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "iletisim",
                defaults: new { controller = "Home", action = "Contact" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
               name: "Gallery",
               url: "galeri",
               defaults: new { controller = "Gallery", action = "GalleryAlbum" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
               name: "GalleryAlbumDetail",
               url: "galeri/{title}/{galleryAlbumId}",
               defaults: new { controller = "Gallery", action = "GalleryAlbumDetail" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", Id = UrlParameter.Optional },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

        }
    }
}