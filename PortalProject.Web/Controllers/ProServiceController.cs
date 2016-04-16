using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
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
    public class ProServiceController : BaseController
    {
         private readonly IProServiceService _proServiceService;

         public ProServiceController(ISettingService settingService, IContactService contactService, IPageService pageService, IProServiceService proServiceService, IUnitOfWork uow)
            : base(settingService, contactService, pageService, proServiceService, uow)
        {
            _proServiceService = proServiceService;
        }

        public ActionResult ProServiceDetail(int proServiceId)
        {
            ProServiceModel _proServiceModel = new ProServiceModel();
            _proServiceModel.ProService = _proServiceService.Find(proServiceId);

            return View(_proServiceModel);
        }
    }
}