﻿using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Banners;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BannerAdd(BannerModel model, HttpPostedFileBase Photo)
        {
            if (Photo != null)
            {
                var fileName = Path.GetFileNameWithoutExtension(Photo.FileName);
                var extension = Path.GetExtension(Photo.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/images/manset"), Guid.NewGuid() + fileName.Replace(" ","").Replace(".","") + extension);
                Photo.SaveAs(path);

                Banner banner = new Banner
                {
                    TitleMain = model.TitleMain,
                    TitleSub = model.TitleSub,
                    Photo = fileName,
                    Url = model.Url,
                    UrlTarget = model.UrlTarget,
                    Order = model.Order,
                    Active = model.Active
                };

                _bannerService.Insert(banner);
                _uow.SaveChanges();
            }

            return RedirectToAction("ListBanner");
        }

        [HttpPost]
        public ActionResult BannerDelete(int bannerId)
        {
            _bannerService.Delete(bannerId);
            _uow.SaveChanges();

            return RedirectToAction("ListBanner");
        }
    }
}