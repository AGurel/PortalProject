using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.Context;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Banners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalProject.Test.Service
{
    [TestClass]
    public class UnitTestBanner
    {
        private PortalProjectContext _context;
        private IUnitOfWork _uow;
        private IBannerService _bannerService;

        [TestInitialize]
        public void TestInitialize()
        {
            _context = new PortalProjectContext();
            _uow = new UnitOfWork(_context);
            _bannerService = new BannerService(_uow);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _context.Dispose();
            _uow.Dispose();
            _bannerService = null;
        }

        [TestMethod]
        public void TestMethodInsertBanner()
        {
            var banner = new Banner
            {
                TitleMain = "test banner main title",
                TitleSub = "test banner sub title",
                Url = "http://www.testurl.com",
                UrlTarget = "_blank",
                Order = 1,
                Active = State.Active
            };

            _bannerService.Insert(banner);
            Assert.AreEqual(1, _uow.SaveChanges());

            _bannerService.Delete(banner);
            _uow.SaveChanges();
        }

        [TestMethod]
        public void TestMethodUpdateBanner()
        {
            var banner = new Banner
            {
                TitleMain = "test banner main title",
                TitleSub = "test banner sub title",
                Url = "http://www.testurl.com",
                UrlTarget = "_blank",
                Order = 1,
                Active = State.Active
            };

            _bannerService.Insert(banner);
            _uow.SaveChanges();

            banner.TitleMain = "updated banner main title";
            banner.TitleSub = "updated test banner sub title";
            _bannerService.Update(banner);
            Assert.AreEqual(1, _uow.SaveChanges());

            var updatedBanner = _bannerService.Find(banner.Id);
            Assert.AreEqual(banner, updatedBanner);

            _bannerService.Delete(banner);
            _uow.SaveChanges();
        }

        [TestMethod]
        public void TestMethodDeleteBanner()
        {
            var banner = new Banner
            {
                TitleMain = "delete test banner main title",
                TitleSub = "delete test banner sub title",
                Url = "http://www.testurl.com",
                UrlTarget = "_blank",
                Order = 1,
                Active = State.Active
            };

            _bannerService.Insert(banner);
            _uow.SaveChanges();

            _bannerService.Delete(banner);
            Assert.AreEqual(1, _uow.SaveChanges());
            Assert.IsNull(_bannerService.Find(banner.Id));
        }
    }
}
