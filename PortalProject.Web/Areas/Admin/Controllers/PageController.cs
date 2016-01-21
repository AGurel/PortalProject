using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Pages;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class PageController : BaseController
    {
        public readonly IPageService _pageService;

        public PageController(IPageService pageService, IUnitOfWork uow)
            : base(uow)
        {
            _pageService = pageService;
        }

        // GET: Admin/Page
        public ActionResult ListPage()
        {
            PageModel _pageModel = new PageModel();
            _pageModel.PageList = _pageService.GetAll().ToList();

            return View(_pageModel);
        }
    }
}