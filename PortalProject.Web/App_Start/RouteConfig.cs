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
                name: "ChangeLanguage",
                url: "home/changelanguage",
                defaults: new { controller = "Home", action = "ChangeLanguage" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );


            routes.MapRoute(
                name: "PageDetail",
                url: "sayfa/{title}/{pageId}",
                defaults: new { controller = "Page", action = "PageDetail" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
               name: "PageDetailEN",
               url: "{lang}/page/{title}/{pageId}",
               defaults: new { controller = "Page", action = "PageDetail" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
                name: "ProductDetail",
                url: "{actionName}/urun/{title}/{productId}",
                defaults: new { controller = "Product", action = "ProductDetail" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
                name: "ProServiceDetail",
                url: "{actionName}/hizmetler/{title}/{proServiceId}",
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
               name: "NewsDetailen",
               url: "{lang}/news/{title}/{newsId}",
               defaults: new { controller = "News", action = "NewsDetail" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
                name: "SSSDetail",
                url: "{actionName}/sss/{title}/{faqId}",
                defaults: new { controller = "Faq", action = "FaqDetail" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
               name: "SSSDetailen",
               url: "{lang}/{actionName}/faq/{title}/{faqId}",
               defaults: new { controller = "Faq", action = "FaqDetail" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
                name: "SSS",
                url: "{actionName}/sss",
                defaults: new { controller = "Faq", action = "Faq" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
                name: "SSSen",
                url: "{lang}/{actionName}/faq",
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
               name: "Newsen",
               url: "{lang}/news",
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
                name: "ContactEN",
                url: "{lang}/contact",
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
               name: "Galleryen",
               url: "{lang}/gallery",
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
                name: "eğitim talep formu",
                url: "{actionName}/iha-egitimi-talep-formu",
                defaults: new { controller = "Home", action = "EduReqForm" },
                namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
               name: "eğitim talep formuen",
               url: "{lang}/{actionName}/uav-training-request-form",
               defaults: new { controller = "Home", action = "EduReqForm" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
               name: "Default",
               url: "",
               defaults: new { controller = "Home", action = "Index" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
            name: "ihalang",
            url: "{lang}/iha",
            constraints: new { lang = @"(\w{2})|(\w{2}-\w{2})" },   // en or en-US
            defaults: new { controller = "Home", action = "Iha" },
            namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
            name: "uavlang",
            url: "{lang}/uav",
            constraints: new { lang = @"(\w{2})|(\w{2}-\w{2})" },   // en or en-US
            defaults: new { controller = "Home", action = "Iha" },
            namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
            name: "iha",
            url: "iha",
            defaults: new { controller = "Home", action = "Iha" },
            namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
            name: "ealang",
            url: "{lang}/ea",
            constraints: new { lang = @"(\w{2})|(\w{2}-\w{2})" },   // en or en-US
            defaults: new { controller = "Home", action = "Ea" },
            namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
            name: "evlang",
            url: "{lang}/ev",
            constraints: new { lang = @"(\w{2})|(\w{2}-\w{2})" },   // en or en-US
            defaults: new { controller = "Home", action = "Ea" },
            namespaces: new[] { "PortalProject.Web.Controllers" }
            );

            routes.MapRoute(
            name: "ea",
            url: "ea",
            defaults: new { controller = "Home", action = "Ea" },
            namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
               name: "DefaultLang",
               url: "{lang}",
               defaults: new { controller = "Home", action = "Index" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
               name: "SendEduReq",
               url: "tr/SendEduReqMail",
               defaults: new { controller = "Home", action = "SendEduReqMail" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
               name: "SendContactMail",
               url: "tr/SendContactMail",
               defaults: new { controller = "Home", action = "SendContactMail" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );

            routes.MapRoute(
               name: "SendMail",
               url: "tr/SendMail",
               defaults: new { controller = "Home", action = "SendMail" },
               namespaces: new[] { "PortalProject.Web.Controllers" }
           );
        }
    }
}