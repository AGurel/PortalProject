using PortalProject.Core.Domain.Entity;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System.Linq;

namespace PortalProject.Service.Contacts
{
    public class ContactService : IContactService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Contact> _contactRepository;

        public ContactService(IUnitOfWork uow)
        {
            _uow = uow;
            _contactRepository = uow.GetRepository<Contact>();
        }

        /// <summary>
        /// Get all contacts.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Contact> GetAll()
        {
            return _contactRepository.GetAll();
        }
        
        /// <summary>
        /// Find contact by contact id
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        public Contact Find(int contactId)
        {
            return _contactRepository.Find(contactId);
        }

        /// <summary>
        /// Insert new contact.
        /// </summary>
        /// <param name="contact"></param>
        public void Insert(Contact contact)
        {
            _contactRepository.Insert(contact);
        }

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <param name="contact"></param>
        public void Update(Contact contact)
        {
            _contactRepository.Update(contact);
        }

        /// <summary>
        /// Delete a contact by contact entity.
        /// </summary>
        /// <param name="setting">Contact</param>
        public void Delete(Contact contact)
        {
            _contactRepository.Delete(contact);
        }

        /// <summary>
        /// Delete a contact by contact id.
        /// </summary>
        /// <param name="contactId">Contact Id</param>
        public void Delete(int contactId)
        {
            _contactRepository.Delete(contactId);
        }
    }
}
