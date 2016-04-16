using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Settings;
using System.Web.Mvc;
using System.Linq;
using PortalProject.Service.Pages;
using PortalProject.Core.Enums.Common;
using PortalProject.Service.ProServices;
using System.Web;
using System.Threading;

namespace PortalProject.Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork _uow;
        protected readonly ISettingService _baseSettingService;
        protected readonly IContactService _baseContactService;
        protected readonly IPageService _basePageService;
        protected readonly IProServiceService _baseProServiceService;

        // GET: Base
        public BaseController(ISettingService baseSettingService, IContactService baseContactService, IPageService basePageService, IProServiceService baseProServiceService, IUnitOfWork uow)
        {
            _uow = uow;
            _baseSettingService = baseSettingService;
            _baseContactService = baseContactService;
            _basePageService = basePageService;
            _baseProServiceService = baseProServiceService;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            string action = this.ControllerContext.RouteData.Values["action"].ToString();
            if (this.ControllerContext.RouteData.Values["actionName"] != null)
            {
                action = this.ControllerContext.RouteData.Values["actionName"].ToString();
            }

            Language language = Language.Turkce;
            //Get the {lang} parameter in the RouteData
            if ((string)this.ControllerContext.RouteData.Values["lang"] == "en")
            {
                language = Language.English;
            }

            ViewBag.Language = language;

            if (action == "iha" || action == "uav")
            {
                ViewBag.Setting = _baseSettingService.GetAll().Where(x => (x.Location == RecordLocation.All || x.Location == RecordLocation.Iha) && x.Language == language).FirstOrDefault();
                ViewBag.UpPages = _basePageService.GetUpPages().Where(x => (x.Location == RecordLocation.All || x.Location == RecordLocation.Iha) && x.Language == language).ToList();
                ViewBag.SubPages = _basePageService.GetSubPages().Where(x => (x.Location == RecordLocation.All || x.Location == RecordLocation.Iha) && x.Language == language).ToList();
            }
            else if (action == "ea" || action == "ev")
            {
                ViewBag.Setting = _baseSettingService.GetAll().Where(x => (x.Location == RecordLocation.All || x.Location == RecordLocation.Ea) && x.Language == language).FirstOrDefault();
                ViewBag.UpPages = _basePageService.GetUpPages().Where(x => (x.Location == RecordLocation.All || x.Location == RecordLocation.Ea) && x.Language == language).ToList();
                ViewBag.SubPages = _basePageService.GetSubPages().Where(x => (x.Location == RecordLocation.All || x.Location == RecordLocation.Ea) && x.Language == language).ToList();
            }
            else
            {
                ViewBag.Setting = _baseSettingService.GetAll().Where(x => (x.Location == RecordLocation.All || x.Location == RecordLocation.Home) && x.Language == language).FirstOrDefault();
                ViewBag.UpPages = _basePageService.GetUpPages().Where(x => (x.Location == RecordLocation.All || x.Location == RecordLocation.Home) && x.Language == language).ToList();
                ViewBag.SubPages = _basePageService.GetSubPages().Where(x => (x.Location == RecordLocation.All || x.Location == RecordLocation.Home) && x.Language == language).ToList();
            }

            ViewBag.ProServices = _baseProServiceService.GetAll().Where(x => x.Active == State.Active && x.Language == language);
            ViewBag.Contact = _baseContactService.GetAll().FirstOrDefault();
        }
    }
}