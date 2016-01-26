using PortalProject.Core.Domain.Entity;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Faqs;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class FaqController : BaseController
    {
        private readonly IFaqService _faqService;

        public FaqController(IFaqService faqService, IUnitOfWork uow)
            : base(uow)
        {
            _faqService = faqService;
        }

        // GET: Admin/Faq
        public ActionResult ListFaq()
        {
            FaqModel _faqModel = new FaqModel();
            _faqModel.FaqList = _faqService.GetAll().ToList();

            return View(_faqModel);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            Faq faq = _faqService.Find(id);

            FaqModel _faqModel = new FaqModel
            {
                Id = faq.Id,
                Active = faq.Active,
                Content = faq.Content,
                Order = faq.Order,
                Title = faq.Title
            };

            return View(_faqModel);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult FaqAdd(FaqModel model)
        {
            Faq faq = new Faq
            {
                Id = model.Id,
                Active = model.Active,
                Content = model.Content,
                Order = model.Order,
                Title = model.Title
            };

            _faqService.Insert(faq);
            _uow.SaveChanges();

            return RedirectToAction("ListFaq");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult FaqEdit(FaqModel model)
        {
            int id = int.Parse(Request.Form["hfId"]);
            Faq faq = _faqService.Find(id);

            faq.Active = model.Active;
            faq.Content = model.Content;
            faq.Order = model.Order;
            faq.Title = model.Title;

            _faqService.Update(faq);
            _uow.SaveChanges();

            return RedirectToAction("ListFaq");
        }

        [HttpPost]
        public ActionResult FaqDelete(int faqId)
        {
            _faqService.Delete(faqId);
            _uow.SaveChanges();

            return RedirectToAction("ListFaq");
        }
    }
}