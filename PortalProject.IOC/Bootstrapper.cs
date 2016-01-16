using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using PortalProject.Core.Domain.Entity;
using PortalProject.Service.Banners;
using PortalProject.Service.Contacts;
using PortalProject.Service.Faqs;
using PortalProject.Service.Newss;
using PortalProject.Service.Pages;
using PortalProject.Service.Products;
using PortalProject.Service.ProServices;
using PortalProject.Service.Settings;
using PortalProject.Service.Galleries;
using PortalProject.Service.GalleryAlbums;

namespace PortalProject.IOC
{
    /// <summary>
    /// Bind the given interface in request scope
    /// </summary>
    public static class IOCExtensions
    {
        public static void BindInRequestScope<T1, T2>(this IUnityContainer container) where T2 : T1
        {
            container.RegisterType<T1, T2>(new HierarchicalLifetimeManager());
        }

        public static void BindInSingletonScope<T1, T2>(this IUnityContainer container) where T2 : T1
        {
            container.RegisterType<T1, T2>(new ContainerControlledLifetimeManager());
        }
    }

    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.BindInRequestScope<IGenericRepository<Banner>, GenericRepository<Banner>>();
            container.BindInRequestScope<IGenericRepository<Contact>, GenericRepository<Contact>>();
            container.BindInRequestScope<IGenericRepository<Faq>, GenericRepository<Faq>>();
            container.BindInRequestScope<IGenericRepository<News>, GenericRepository<News>>();
            container.BindInRequestScope<IGenericRepository<Page>, GenericRepository<Page>>();
            container.BindInRequestScope<IGenericRepository<Product>, GenericRepository<Product>>();
            container.BindInRequestScope<IGenericRepository<ProService>, GenericRepository<ProService>>();
            container.BindInRequestScope<IGenericRepository<Setting>, GenericRepository<Setting>>();
            container.BindInRequestScope<IGenericRepository<Gallery>, GenericRepository<Gallery>>();
            container.BindInRequestScope<IGenericRepository<GalleryAlbum>, GenericRepository<GalleryAlbum>>();

            container.BindInRequestScope<IUnitOfWork, UnitOfWork>();

            container.BindInRequestScope<IBannerService, BannerService>();
            container.BindInRequestScope<IContactService, ContactService>();
            container.BindInRequestScope<IFaqService, FaqService>();
            container.BindInRequestScope<INewsService, NewsService>();
            container.BindInRequestScope<IPageService, PageService>();
            container.BindInRequestScope<IProductService, ProductService>();
            container.BindInRequestScope<IProServiceService, ProServiceService>();
            container.BindInRequestScope<ISettingService, SettingService>();
            container.BindInRequestScope<IGalleryService, GalleryService>();
            container.BindInRequestScope<IGalleryAlbumService, GalleryAlbumService>();
        }
    }
}