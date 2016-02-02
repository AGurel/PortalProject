using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                 "Admin_banner",
                 "Admin/banner/list",
                 new { controller = "Banner", action = "ListBanner" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_banneradd",
                 "Admin/banner/add",
                 new { controller = "Banner", action = "Add" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_banneredit",
                 "Admin/banner/edit/{id}",
                 new { controller = "Banner", action = "Edit" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_bannerdelete",
                 "Admin/banner/delete/{id}",
                 new { controller = "Banner", action = "BannerDelete" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                "Admin_news",
                "Admin/news/list",
                new { controller = "News", action = "ListNews" },
                new[] { "PortalProject.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                 "Admin_newsadd",
                 "Admin/news/add",
                 new { controller = "News", action = "Add" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_newsedit",
                 "Admin/news/edit/{id}",
                 new { controller = "News", action = "Edit" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_newsdelete",
                 "Admin/news/delete/{id}",
                 new { controller = "News", action = "NewsDelete" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
               "Admin_faq",
               "Admin/faq/list",
               new { controller = "Faq", action = "ListFaq" },
               new[] { "PortalProject.Web.Areas.Admin.Controllers" }
           );

            context.MapRoute(
                 "Admin_faqadd",
                 "Admin/faq/add",
                 new { controller = "Faq", action = "Add" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_faqedit",
                 "Admin/faq/edit/{id}",
                 new { controller = "Faq", action = "Edit" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_faqdelete",
                 "Admin/faq/delete/{id}",
                 new { controller = "Faq", action = "FaqDelete" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                "Admin_page",
                "Admin/page/list",
                new { controller = "Page", action = "ListPage" },
                new[] { "PortalProject.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                "Admin_pageadd",
                "Admin/page/add",
                new { controller = "Page", action = "Add" },
                new[] { "PortalProject.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                 "Admin_pageedit",
                 "Admin/page/edit/{id}",
                 new { controller = "Page", action = "Edit" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_pagedelete",
                 "Admin/page/delete/{id}",
                 new { controller = "Page", action = "PageDelete" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
               "Admin_product",
               "Admin/product/list",
               new { controller = "Product", action = "ListProduct" },
               new[] { "PortalProject.Web.Areas.Admin.Controllers" }
           );

            context.MapRoute(
                "Admin_productadd",
                "Admin/product/add",
                new { controller = "Product", action = "Add" },
                new[] { "PortalProject.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                 "Admin_productedit",
                 "Admin/product/edit/{id}",
                 new { controller = "Product", action = "Edit" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_productdelete",
                 "Admin/product/delete/{id}",
                 new { controller = "Product", action = "PageDelete" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                  "Admin_proservice",
                  "Admin/proservice/list",
                  new { controller = "ProService", action = "ListProService" },
                  new[] { "PortalProject.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                "Admin_proserviceadd",
                "Admin/proservice/add",
                new { controller = "ProService", action = "Add" },
                new[] { "PortalProject.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                 "Admin_proserviceedit",
                 "Admin/proservice/edit/{id}",
                 new { controller = "ProService", action = "Edit" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_proservicedelete",
                 "Admin/proservice/delete/{id}",
                 new { controller = "ProService", action = "ProServiceDelete" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
             );

            context.MapRoute(
                 "Admin_galleryalbum",
                 "Admin/galleryalbum/list",
                 new { controller = "Gallery", action = "ListGalleryAlbum" },
                 new[] { "PortalProject.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
               "Admin_default",
               "Admin/{controller}/{action}/{id}",
               new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               new[] { "PortalProject.Web.Areas.Admin.Controllers" }
           );
        }
    }
}