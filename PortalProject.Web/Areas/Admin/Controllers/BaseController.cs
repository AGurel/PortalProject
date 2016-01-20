using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Settings;
using System.Web.Mvc;
using System.Linq;
using PortalProject.Service.Pages;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork _uow;

        // GET: Base
        public BaseController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }
}