using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.Context;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using PortalProject.Service.Faqs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalProject.Test.Service
{
    [TestClass]
    public class UnitTestFaq
    {
        private PortalProjectContext _context;
        private IUnitOfWork _uow;
        private IFaqService _faqService;

        [TestInitialize]
        public void TestInitialize()
        {
            _context = new PortalProjectContext();
            _uow = new UnitOfWork(_context);
            _faqService = new FaqService(_uow);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _context.Dispose();
            _uow.Dispose();
            _faqService = null;
        }

        [TestMethod]
        public void TestMethodInsertFaq()
        {
            var faq = new Faq
            {
                Active = State.Active,
                Content = "test faq content",
                Order = 1,
                SeoUrl = "test-faq-content",
                Title = "test faq title"
            };

            _faqService.Insert(faq);
            Assert.AreEqual(1, _uow.SaveChanges());

            _faqService.Delete(faq);
            _uow.SaveChanges();
        }

        [TestMethod]
        public void TestMethodUpdateFaq()
        {
            var faq = new Faq
            {
                Active = State.Active,
                Content = "test faq content",
                Order = 1,
                SeoUrl = "test-faq-content",
                Title = "test faq title"
            };

            _faqService.Insert(faq);
            _uow.SaveChanges();

            faq.Title = "updated test faq title";
            faq.Content = "updated test faq content data";
            _faqService.Update(faq);
            Assert.AreEqual(1, _uow.SaveChanges());

            var updatedFaq = _faqService.Find(faq.Id);
            Assert.AreEqual(faq, updatedFaq);

            _faqService.Delete(faq);
            _uow.SaveChanges();
        }

        [TestMethod]
        public void TestMethodDeleteFaq()
        {
            var faq = new Faq
            {
                Active = State.Active,
                Content = "test faq content",
                Order = 1,
                SeoUrl = "test-faq-content",
                Title = "test faq title"
            };
            _faqService.Insert(faq);
            _uow.SaveChanges();

            _faqService.Delete(faq);
            Assert.AreEqual(1, _uow.SaveChanges());
            Assert.IsNull(_faqService.Find(faq.Id));
        }
    }
}
