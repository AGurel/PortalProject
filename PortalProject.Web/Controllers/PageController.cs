using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Pages;
using PortalProject.Service.Settings;
using PortalProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace PortalProject.Web.Controllers
{
    public class PageController : BaseController 
    {
        private readonly IPageService _pageService;

        public PageController(ISettingService settingService, IContactService contactService, IPageService pageService, IUnitOfWork uow)
            : base(settingService, contactService, pageService, uow)
        {
            _pageService = pageService;
        }

        // GET: Page
        public ActionResult PageDetail(int pageId)
        {
            PageModel _pageModel = new PageModel();
            _pageModel.Page = _pageService.Find(pageId);

            return View(_pageModel);
        }
    }
}