using System;
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
                defaults: new { controller = "Page", action = "PageDetail" }
            );

            routes.MapRoute(
                name: "ProductDetail",
                url: "urun/{title}/{productId}",
                defaults: new { controller = "Product", action = "ProductDetail" }
            );

            routes.MapRoute(
                name: "ProServiceDetail",
                url: "hizmet/{title}/{proServiceId}",
                defaults: new { controller = "ProService", action = "ProServiceDetail" }
            );

            routes.MapRoute(
                name: "NewsDetail",
                url: "haber/{title}/{newsId}",
                defaults: new { controller = "News", action = "NewsDetail" }
            );

            routes.MapRoute(
                name: "SSSDetail",
                url: "sss/{title}/{faqId}",
                defaults: new { controller = "Faq", action = "FaqDetail" }
            );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", Id = UrlParameter.Optional }
           );

        }
    }
}