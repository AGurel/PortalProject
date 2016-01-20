using PortalProject.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IUnitOfWork uow)
            : base(uow)
        {

        }

        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}