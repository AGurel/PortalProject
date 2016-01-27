using PortalProject.Core.Domain.Entity;
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

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            ProService proService = _proServiceService.Find(id);

            ProServiceModel _proServiceModel = new ProServiceModel
            {
                Id = proService.Id,
                Active = proService.Active,
                Description = proService.Description,
                Order = proService.Order,
                Name = proService.Name,
                IconClass = proService.IconClass
            };

            return View(_proServiceModel);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProServiceAdd(ProServiceModel model)
        {
            ProService proService = new ProService
            {
                Id = model.Id,
                Active = model.Active,
                Description = model.Description,
                Order = model.Order,
                Name = model.Name,
                IconClass = model.IconClass
            };

            _proServiceService.Insert(proService);
            _uow.SaveChanges();

            return RedirectToAction("ListProService");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProserviceEdit(ProServiceModel model)
        {
            int id = int.Parse(Request.Form["hfId"]);
            ProService proService = _proServiceService.Find(id);

            proService.Active = model.Active;
            proService.Description = model.Description;
            proService.Order = model.Order;
            proService.Name = model.Name;
            proService.IconClass = model.IconClass;

            _proServiceService.Update(proService);
            _uow.SaveChanges();

            return RedirectToAction("ListProService");
        }

        [HttpPost]
        public ActionResult ProServiceDelete(int proServiceId)
        {
            _proServiceService.Delete(proServiceId);
            _uow.SaveChanges();

            return RedirectToAction("ListProService");
        }
    }
}