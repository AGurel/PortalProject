using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Settings;
using System.Web.Mvc;
using System.Linq;
using PortalProject.Service.Pages;

namespace PortalProject.Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork _uow;
        protected readonly ISettingService _baseSettingService;
        protected readonly IContactService _baseContactService;
        protected readonly IPageService _basePageService;

        // GET: Base
        public BaseController(ISettingService baseSettingService, IContactService baseContactService, IPageService basePageService, IUnitOfWork uow)
        {
            _uow = uow;
            _baseSettingService = baseSettingService;
            _baseContactService = baseContactService;
            _basePageService = basePageService;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            ViewBag.Setting = _baseSettingService.GetAll().FirstOrDefault();
            ViewBag.Contact = _baseContactService.GetAll().FirstOrDefault();
            ViewBag.UpPages = _basePageService.GetUpPages().ToList();
            ViewBag.SubPages = _basePageService.GetSubPages().ToList();
        }
    }
}