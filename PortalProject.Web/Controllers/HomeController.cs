using PortalProject.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalProject.Service.Banners;
using PortalProject.Web.Models;
using PortalProject.Service.Products;
using PortalProject.Service.ProServices;
using PortalProject.Service.Newss;
using PortalProject.Service.Faqs;
using PortalProject.Service.Galleries;
using PortalProject.Service.Settings;
using PortalProject.Service.Contacts;
using PortalProject.Service.Pages;

namespace PortalProject.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IBannerService _bannerService;
        private readonly IProductService _productService;
        private readonly IProServiceService _proServiceService;
        private readonly INewsService _newsService;
        private readonly IFaqService _faqService;
        private readonly IGalleryService _galleryService;

        public HomeController(IBannerService bannerService, IProductService productService, IProServiceService proServiceService, INewsService newsService, IFaqService faqService, IGalleryService galleryService, ISettingService settingService, IContactService contactService, IPageService pageService, IUnitOfWork uow)
            : base(settingService, contactService, pageService, uow)
        {
            _bannerService = bannerService;
            _productService = productService;
            _proServiceService = proServiceService;
            _newsService = newsService;
            _faqService = faqService;
            _galleryService = galleryService;
        }

        // GET: Home
        public ActionResult Index()
        {
            HomeModel _homeModel = new HomeModel();

            _homeModel.BannerList = _bannerService.GetAll().ToList();
            _homeModel.ProductList = _productService.GetAll().ToList();
            _homeModel.ProServiceList = _proServiceService.GetAll().ToList();
            _homeModel.NewsList = _newsService.GetAll().ToList();
            _homeModel.FaqList = _faqService.GetAll().ToList();
            _homeModel.GalleryList = _galleryService.GetRandomGalleries(6).ToList();

            return View(_homeModel);
        }
    }
}