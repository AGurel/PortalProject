﻿using PortalProject.Core.Enums.Common;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Faqs;
using PortalProject.Service.Pages;
using PortalProject.Service.ProServices;
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

        public FaqController(ISettingService settingService, IContactService contactService, IPageService pageService, IFaqService faqService, IProServiceService proServiceService, IUnitOfWork uow)
            : base(settingService, contactService, pageService, proServiceService, uow)
        {
            _faqService = faqService;
        }

        public ActionResult FaqDetail(int faqId)
        {
            FaqModel _faqModel = new FaqModel();
            _faqModel.Faq = _faqService.Find(faqId);

            return View(_faqModel);
        }

        public ActionResult Faq()
        {
            FaqModel _faqModel = new FaqModel();
            _faqModel.FaqList = _faqService.GetAll().Where(x => x.Active == State.Active).ToList();

            return View(_faqModel);
        }
    }
}