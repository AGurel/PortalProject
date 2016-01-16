using PortalProject.Core.Domain.Entity;
using System.Linq;

namespace PortalProject.Service.Faqs
{
    public interface IFaqService
    {
        /// <summary>
        /// Get all Faq.
        /// </summary>
        /// <returns></returns>
        IQueryable<Faq> GetAll();

        /// <summary>
        /// Find faq by id.
        /// </summary>
        /// <param name="faqId"></param>
        /// <returns></returns>
        Faq Find(int faqId);

        /// <summary>
        /// Insert a new faq.
        /// </summary>
        /// <param name="faq"></param>
        void Insert(Faq faq);

        /// <summary>
        /// Update a faq.
        /// </summary>
        /// <param name="faq"></param>
        void Update(Faq faq);

        /// <summary>
        /// Delete a faq by faq.
        /// </summary>
        /// <param name="faq">Faq</param>
        void Delete(Faq faq);

        /// <summary>
        /// Delete a faq by faq id.
        /// </summary>
        /// <param name="faqId"></param>
        void Delete(int faqId);
    }
}
