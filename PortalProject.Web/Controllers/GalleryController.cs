using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Galleries;
using PortalProject.Service.GalleryAlbums;
using PortalProject.Service.Pages;
using PortalProject.Service.Settings;
using PortalProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly IGalleryAlbumService _galleryAlbumService;
        private readonly IGalleryService _galleryService;

        public GalleryController(ISettingService settingService, IContactService contactService, IPageService pageService, IGalleryAlbumService galleryAlbumService, IGalleryService galleryService, IUnitOfWork uow)
            : base(settingService, contactService, pageService, uow)
        {
            _galleryAlbumService = galleryAlbumService;
            _galleryService = galleryService;
        }

        public ActionResult GalleryAlbum()
        {
            GalleryModel _galleryModel = new GalleryModel();
            _galleryModel.GalleryAlbumList = _galleryAlbumService.GetAll().ToList();

            return View(_galleryModel);
        }

        public ActionResult GalleryAlbumDetail(int galleryAlbumId)
        {
            GalleryModel _galleryModel = new GalleryModel();
            _galleryModel.GalleryAlbum = _galleryAlbumService.Find(galleryAlbumId);
            _galleryModel.GalleryList = _galleryService.GetGalleriesByGalleryAlbum(galleryAlbumId).ToList();

            return View(_galleryModel);
        }
    }
}