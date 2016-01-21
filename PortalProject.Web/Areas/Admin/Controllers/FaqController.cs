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
    }
}