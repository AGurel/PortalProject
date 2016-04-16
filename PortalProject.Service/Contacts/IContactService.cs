using PortalProject.Core.Domain.Entity;
using System.Linq;

namespace PortalProject.Service.Contacts
{
    public interface IContactService
    {
        /// <summary>
        /// Get all contacts.
        /// </summary>
        /// <returns></returns>
        IQueryable<Contact> GetAll();

        /// <summary>
        /// Find contact by id.
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        Contact Find(int contactId);

        /// <summary>
        /// Insert a new contact.
        /// </summary>
        /// <param name="contact"></param>
        void Insert(Contact contact);

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <param name="contact"></param>
        void Update(Contact contact);

        /// <summary>
        /// Delete a contact by contact.
        /// </summary>
        /// <param name="contact">Contact</param>
        void Delete(Contact contact);

        /// <summary>
        /// Delete a contact by contact id.
        /// </summary>
        /// <param name="contactId"></param>
        void Delete(int contactId);

        /// <summary>
        /// Send e-mail with settings in web.config
        /// </summary>
        void SendMail(string mailFrom, string mailTo, string subject, string mailBody);
    }
}
