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
using PortalProject.Core.Enums.Common;
using System.Threading;

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
        private readonly IPageService _pageService;
        private readonly IContactService _contactService;

        public HomeController(IBannerService bannerService, IProductService productService, IProServiceService proServiceService, INewsService newsService, IFaqService faqService, IGalleryService galleryService, ISettingService settingService, IContactService contactService, IPageService pageService, IUnitOfWork uow)
            : base(settingService, contactService, pageService, proServiceService, uow)
        {
            _bannerService = bannerService;
            _productService = productService;
            _proServiceService = proServiceService;
            _newsService = newsService;
            _faqService = faqService;
            _galleryService = galleryService;
            _pageService = pageService;
            _contactService = contactService;
        }

        // GET: Home
        public ActionResult Index()
        {
            HomeModel _homeModel = new HomeModel();

            Language language = (Language)ViewBag.Language;

            if (language == Language.Turkce)
            {
                _homeModel.pageAbout = _pageService.Find(4);
            }
            else if (language == Language.English)
            {
                _homeModel.pageAbout = _pageService.Find(8);
            }
            

            return View(_homeModel);
        }

        //GET: Iha
        public ActionResult Iha()
        {
            HomeModel _homeModel = new HomeModel();

            _homeModel.BannerList = _bannerService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Iha || x.Location == RecordLocation.All)).ToList();
            _homeModel.ProductList = _productService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Iha || x.Location == RecordLocation.All)).ToList();
            _homeModel.ProServiceList = _proServiceService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Iha || x.Location == RecordLocation.All)).ToList();
            _homeModel.NewsList = _newsService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Iha || x.Location == RecordLocation.All)).ToList();
            _homeModel.FaqList = _faqService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Iha || x.Location == RecordLocation.All)).ToList();
            _homeModel.GalleryList = _galleryService.GetRandomGalleries(6).ToList();

            return View(_homeModel);
        }

        //GET: Ea
        public ActionResult Ea()
        {
            HomeModel _homeModel = new HomeModel();

            _homeModel.BannerList = _bannerService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Ea || x.Location == RecordLocation.All)).ToList();
            _homeModel.ProductList = _productService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Ea || x.Location == RecordLocation.All)).ToList();
            _homeModel.ProServiceList = _proServiceService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Ea || x.Location == RecordLocation.All)).ToList();
            _homeModel.NewsList = _newsService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Ea || x.Location == RecordLocation.All)).ToList();
            _homeModel.FaqList = _faqService.GetAll().Where(x => x.Active == State.Active && (x.Location == RecordLocation.Ea || x.Location == RecordLocation.All)).ToList();
            _homeModel.GalleryList = _galleryService.GetRandomGalleries(6).ToList();

            return View(_homeModel);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult EduReqForm()
        {
            return View();
        }

        public ActionResult SendMail(HomeModel homeModel)
        {
            if (!string.IsNullOrWhiteSpace(homeModel.frmEMail) && !string.IsNullOrWhiteSpace(homeModel.frmMessage) && !string.IsNullOrWhiteSpace(homeModel.frmNameSurname))
            {
                string mailBody = "İsim Soyisim : " + homeModel.frmNameSurname + "<br/>E-Mail Adresi : " + homeModel.frmEMail + "<br/>Mesaj : " + homeModel.frmMessage;
                _contactService.SendMail("abdurrahmangurel@hacettepetargem.com", "iha_egitim@hacettepetargem.com", "İletişim Formundan Yeni Talep Alındı!", mailBody);
                return Json("Talebinizi aldık. En kısa sürede geri dönüş yapacağız.", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Tüm alanları doldurmadınız!", JsonRequestBehavior.AllowGet);
            }
        }

    
        public ActionResult SendContactMail(ContactModel contactModel)
        {
            if (!string.IsNullOrWhiteSpace(contactModel.frmEMail) && !string.IsNullOrWhiteSpace(contactModel.frmMessage) && !string.IsNullOrWhiteSpace(contactModel.frmName) && !string.IsNullOrWhiteSpace(contactModel.frmSurname) && !string.IsNullOrWhiteSpace(contactModel.frmEMail))
            {
                string mailBody = "İsim Soyisim : " + contactModel.frmName + " " + contactModel.frmSurname + "<br/>E-Mail Adresi : " + contactModel.frmEMail + "<br/>Telefon : " + contactModel.frmPhone + "<br/>Mesaj : " + contactModel.frmMessage;
                _contactService.SendMail("abdurrahmangurel@hacettepetargem.com", "iha_egitim@hacettepetargem.com", "İletişim Formundan Yeni Talep Alındı!", mailBody);
                return Json("Talebinizi aldık. En kısa sürede geri dönüş yapacağız.", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Tüm alanları doldurmadınız!", JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SendEduReqMail(EduReqModel eduReqModel)
        {
            if (!string.IsNullOrWhiteSpace(eduReqModel.frmNameSurname) && !string.IsNullOrWhiteSpace(eduReqModel.frmEMail) && !string.IsNullOrWhiteSpace(eduReqModel.frmPhone))
            {
                string mailBody = "İsim Soyisim : " + eduReqModel.frmNameSurname + "<br/>E-Mail Adresi : " + eduReqModel.frmEMail + "<br/>Telefon : " + eduReqModel.frmPhone + "<br/>Şehir : " + eduReqModel.frmCity + "<br/>Şehir(Diğer) : " + eduReqModel.frmCityOther + "<br/>Tarih : " + eduReqModel.frmDate + "<br/>Tarih(Diğer) : " + eduReqModel.frmDateOther + "<br/>Çalıştığı Şirket : " + eduReqModel.frmCompany + "<br/>Ünvanı : " + eduReqModel.frmJob + "<br/>Mesaj : " + eduReqModel.frmMessage;
                _contactService.SendMail("abdurrahmangurel@hacettepetargem.com", "iha_egitim@hacettepetargem.com", "Yeni Eğitim Talebi Alındı!", mailBody);
                return Json("Talebinizi aldık. En kısa sürede geri dönüş yapacağız.", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Tüm alanları doldurmadınız!", JsonRequestBehavior.AllowGet);
            }
        }
    }
}