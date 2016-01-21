using PortalProject.Data.UnitOfWork;
using PortalProject.Service.GalleryAlbums;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly IGalleryAlbumService _galleryAlbumService;

        public GalleryController(IGalleryAlbumService galleryAlbumService, IUnitOfWork uow)
            : base(uow)
        {
            _galleryAlbumService = galleryAlbumService;
        }

        // GET: Admin/Gallery
        public ActionResult ListGalleryAlbum()
        {
            GalleryModel _galleryModel = new GalleryModel();
            _galleryModel.GalleryAlbumList = _galleryAlbumService.GetAll().ToList();

            return View(_galleryModel);
        }
    }
}