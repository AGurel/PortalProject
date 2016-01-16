using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Faqs;
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
    public class FaqController : BaseController
    {
        private readonly IFaqService _faqService;

        public FaqController(ISettingService settingService, IContactService contactService, IPageService pageService, IFaqService faqService, IUnitOfWork uow)
            : base(settingService, contactService, pageService, uow)
        {
            _faqService = faqService;
        }

        // GET: Page
        public ActionResult FaqDetail(int faqId)
        {
            FaqModel _faqModel = new FaqModel();
            _faqModel.Faq = _faqService.Find(faqId);

            return View(_faqModel);
        }
    }
}