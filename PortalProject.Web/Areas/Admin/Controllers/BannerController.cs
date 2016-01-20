using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Banners;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class BannerController : BaseController
    {
        public readonly IBannerService _bannerService;

        public BannerController(IBannerService bannerService, IUnitOfWork uow)
            : base(uow)
        {
            _bannerService = bannerService;
        }

        // GET: Admin/Banner
        public ActionResult ListBanner()
        {
            BannerModel _bannerModel = new BannerModel();
            _bannerModel.BannerList = _bannerService.GetAll().ToList();

            return View(_bannerModel);
        }
    }
}