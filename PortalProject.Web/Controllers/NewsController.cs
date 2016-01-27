using PortalProject.Core.Enums.Common;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Newss;
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
    public class NewsController : BaseController
    {
       private readonly INewsService _newsService;

         public NewsController(ISettingService settingService, IContactService contactService, IPageService pageService, INewsService newsService, IUnitOfWork uow)
            : base(settingService, contactService, pageService, uow)
        {
            _newsService = newsService;
        }

        public ActionResult NewsDetail(int newsId)
        {
            NewsModel _newsModel = new NewsModel();
            _newsModel.News = _newsService.Find(newsId);

            return View(_newsModel);
        }

        public ActionResult News()
        {
            NewsModel _newsModel = new NewsModel();
            _newsModel.NewsList = _newsService.GetAll().Where(x => x.Active == State.Active).ToList();

            return View(_newsModel);
        }
    }
}