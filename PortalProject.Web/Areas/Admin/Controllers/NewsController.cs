using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Newss;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class NewsController : BaseController
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService, IUnitOfWork uow)
            : base(uow)
        {
            _newsService = newsService;
        }

        // GET: Admin/News
        public ActionResult ListNews()
        {
            NewsModel _newsModel = new NewsModel();
            _newsModel.NewsList = _newsService.GetAll().ToList();

            return View(_newsModel);
        }
    }
}