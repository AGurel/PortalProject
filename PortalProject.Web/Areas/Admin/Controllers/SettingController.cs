using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Banners;
using PortalProject.Service.Settings;
using PortalProject.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalProject.Web.Areas.Admin.Controllers
{
    public class SettingController : BaseController
    {
        public readonly ISettingService _settingService;

        public SettingController(ISettingService settingService, IUnitOfWork uow)
            : base(uow)
        {
            _settingService = settingService;
        }

        // GET: Admin/Banner
        public ActionResult ListSetting()
        {
            SettingModel _settingModel = new SettingModel();
            _settingModel.SettingList = _settingService.GetAll().ToList();

            return View(_settingModel);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            Setting setting = _settingService.Find(id);

            SettingModel _settingModel = new SettingModel
            {
                Description = setting.Description,
                Facebook = setting.Facebook,
                Id = setting.Id,
                LinkedIn = setting.LinkedIn,
                SMTPLogin = setting.SMTPLogin,
                SMTPPassword = setting.SMTPPassword,
                SMTPPort = setting.SMTPPort,
                SMTPServer = setting.SMTPServer,
                SMTPSSL = setting.SMTPSSL,
                Title = setting.Title,
                Twitter = setting.Twitter,
                Youtube = setting.Youtube
            };

            return View(_settingModel);
        }

        [HttpPost]
        public ActionResult SettingAdd(SettingModel model)
        {
            Setting setting = new Setting
               {
                   Description = model.Description,
                   Facebook = model.Facebook,
                   LinkedIn = model.LinkedIn,
                   SMTPLogin = model.SMTPLogin,
                   SMTPPassword = model.SMTPPassword,
                   SMTPPort = model.SMTPPort,
                   SMTPServer = model.SMTPServer,
                   SMTPSSL = model.SMTPSSL,
                   Title = model.Title,
                   Twitter = model.Twitter,
                   Youtube = model.Youtube
               };

            _settingService.Insert(setting);
            _uow.SaveChanges();

            return RedirectToAction("ListSetting");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SettingEdit(SettingModel model)
        {
            int id = int.Parse(Request.Form["hfId"]);
            Setting setting = _settingService.Find(id);

            setting.Description = model.Description;
            setting.Facebook = model.Facebook;
            setting.LinkedIn = model.LinkedIn;
            setting.SMTPLogin = model.SMTPLogin;
            setting.SMTPPassword = model.SMTPPassword;
            setting.SMTPPort = model.SMTPPort;
            setting.SMTPServer = model.SMTPServer;
            setting.SMTPSSL = model.SMTPSSL;
            setting.Title = model.Title;
            setting.Twitter = model.Twitter;
            setting.Youtube = model.Youtube;

            _settingService.Update(setting);
            _uow.SaveChanges();

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SettingDelete(int settingId)
        {
            _settingService.Delete(settingId);
            _uow.SaveChanges();

            return RedirectToAction("ListSetting");
        }
    }
}