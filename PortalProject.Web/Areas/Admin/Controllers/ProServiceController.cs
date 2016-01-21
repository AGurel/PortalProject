using PortalProject.Data.UnitOfWork;
using PortalProject.Service.ProServices;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class ProServiceController : BaseController
    {
        private readonly IProServiceService _proServiceService;

        public ProServiceController(IProServiceService proServiceService, IUnitOfWork uow)
            : base(uow)
        {
            _proServiceService = proServiceService;
        }

        // GET: Admin/ProService
        public ActionResult ListProService()
        {
            ProServiceModel _proServiceModel = new ProServiceModel();
            _proServiceModel.ProServiceList = _proServiceService.GetAll().ToList();

            return View(_proServiceModel);
        }
    }
}