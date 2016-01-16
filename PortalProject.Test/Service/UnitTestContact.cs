using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.Context;
using PortalProject.Data.UnitOfWork;
using PortalProject.Service.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalProject.Test.Service
{
    [TestClass]
    public class UnitTestContact
    {
        private PortalProjectContext _context;
        private IUnitOfWork _uow;
        private IContactService _contactService;

        [TestInitialize]
        public void TestInitialize()
        {
            _context = new PortalProjectContext();
            _uow = new UnitOfWork(_context);
            _contactService = new ContactService(_uow);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _context.Dispose();
            _uow.Dispose();
            _contactService = null;
        }

        [TestMethod]
        public void TestMethodInsertContact()
        {
            var contact = new Contact
            {
                Address = "test adres",
                Email = "test@testmail.com",
                Map = "test map data",
                Phone = "+90 506 994 21 63"              
            };

            _contactService.Insert(contact);
            Assert.AreEqual(1, _uow.SaveChanges());

            _contactService.Delete(contact);
            _uow.SaveChanges();
        }

        [TestMethod]
        public void TestMethodUpdateContact()
        {
            var contact = new Contact
            {
                Address = "test adres",
                Email = "test@testmail.com",
                Map = "test map data",
                Phone = "+90 506 994 21 63"    
            };

            _contactService.Insert(contact);
            _uow.SaveChanges();

            contact.Address = "updated test Contact adress";
            contact.Map = "updated test Contact map data";
            _contactService.Update(contact);
            Assert.AreEqual(1, _uow.SaveChanges());

            var updatedContact = _contactService.Find(contact.Id);
            Assert.AreEqual(contact, updatedContact);

            _contactService.Delete(contact);
            _uow.SaveChanges();
        }

        [TestMethod]
        public void TestMethodDeleteContact()
        {
            var Contact = new Contact
            {
                Address = "delete test adres",
                Email = "deletetest@testmail.com",
                Map = "delete test map data",
                Phone = "+90 506 994 21 63"
            };

            _contactService.Insert(Contact);
            _uow.SaveChanges();

            _contactService.Delete(Contact);
            Assert.AreEqual(1, _uow.SaveChanges());
            Assert.IsNull(_contactService.Find(Contact.Id));
        }
    }
}
