using PortalProject.Core.Domain.Entity;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Newss;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            News news = _newsService.Find(id);

            NewsModel _newsModel = new NewsModel
            {
                Id = news.Id,
                Active = news.Active,
                Content = news.Content,
                Creator = news.Creator,
                Date = news.Date,
                Title = news.Title
            };

            return View(_newsModel);
        }

        [HttpPost]
        public ActionResult NewsAdd(NewsModel model, HttpPostedFileBase Photo)
        {
            if (Photo != null)
            {
                var fileName = Path.GetFileNameWithoutExtension(Photo.FileName);
                var extension = Path.GetExtension(Photo.FileName);
                var fileFullName = Guid.NewGuid() + fileName.Replace(" ", "").Replace(".", "") + extension;
                var path = Path.Combine(Server.MapPath("~/Content/images/haber"), fileFullName);
                Photo.SaveAs(path);

                News news = new News
                {
                    Active = model.Active,
                    Content = model.Content,
                    Photo = "images/haber/" + fileFullName,
                    Creator = model.Creator,
                    Date = model.Date,
                    Title = model.Title
                };

                _newsService.Insert(news);
                _uow.SaveChanges();
            }

            return RedirectToAction("ListNews");
        }

        [HttpPost]
        public ActionResult NewsEdit(NewsModel model, HttpPostedFileBase Photo)
        {
            int id = int.Parse(Request.Form["hfId"]);
            News news = _newsService.Find(id);

            if (Photo != null)
            {
                var fileName = Path.GetFileNameWithoutExtension(Photo.FileName);
                var extension = Path.GetExtension(Photo.FileName);
                var fileFullName = Guid.NewGuid() + fileName.Replace(" ", "").Replace(".", "") + extension;
                var path = Path.Combine(Server.MapPath("~/Content/images/haber"), fileFullName);
                Photo.SaveAs(path);
                news.Photo = "images/haber/" + fileFullName;
            }

            news.Active = model.Active;
            news.Content = model.Content;
            news.Creator = model.Creator;
            news.Date = model.Date;
            news.Title = model.Title;

            _newsService.Update(news);
            _uow.SaveChanges();

            return RedirectToAction("ListNews");
        }

        [HttpPost]
        public ActionResult NewsDelete(int newsId)
        {
            _newsService.Delete(newsId);
            _uow.SaveChanges();

            return RedirectToAction("ListNews");
        }
    }
}