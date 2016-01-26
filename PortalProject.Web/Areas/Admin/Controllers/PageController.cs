using PortalProject.Core.Domain.Entity;
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

        public ActionResult Add()
        {
            PageModel _pageModel = new PageModel
            {
                PageList = _pageService.GetUpPages().ToList()
            };

            return View(_pageModel);
        }

        public ActionResult Edit(int id)
        {
            Page page = _pageService.Find(id);

            PageModel _pageModel = new PageModel
            {
                Id = page.Id,
                Active = page.Active,
                Content = page.Content,
                Order = page.Order,
                Title = page.Title,
                UpPageId = page.UpPageId,
                PageList = _pageService.GetUpPages().ToList()
            };

            return View(_pageModel);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PageAdd(PageModel model)
        {
            Page page = new Page
            {
                Active = model.Active,
                Content = model.Content,
                Order = model.Order,
                Title = model.Title,
                UpPageId = model.UpPageId
            };

            _pageService.Insert(page);
            _uow.SaveChanges();

            return RedirectToAction("ListPage");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PageEdit(PageModel model)
        {
            int id = int.Parse(Request.Form["hfId"]);
            Page page = _pageService.Find(id);

            page.Active = model.Active;
            page.Content = model.Content;
            page.Order = model.Order;
            page.Title = model.Title;
            page.UpPageId = model.UpPageId;

            _pageService.Update(page);
            _uow.SaveChanges();

            return RedirectToAction("ListPage");
        }

        [HttpPost]
        public ActionResult PageDelete(int pageId)
        {
            _pageService.Delete(pageId);
            _uow.SaveChanges();

            return RedirectToAction("ListPage");
        }
    }
}