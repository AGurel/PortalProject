using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System.Linq;

namespace PortalProject.Service.Faqs
{
    public class FaqService : IFaqService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Faq> _faqRepository;

        public FaqService(IUnitOfWork uow)
        {
            _uow = uow;
            _faqRepository = uow.GetRepository<Faq>();
        }

        /// <summary>
        /// Get all faqs.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Faq> GetAll()
        {
            return _faqRepository.GetAll().Where(x => x.Active == State.Active).OrderBy(x => x.Order);
        }
        
        /// <summary>
        /// Find faq by faq id
        /// </summary>
        /// <param name="faqId"></param>
        /// <returns></returns>
        public Faq Find(int faqId)
        {
            return _faqRepository.Find(faqId);
        }

        /// <summary>
        /// Insert new faq.
        /// </summary>
        /// <param name="faq"></param>
        public void Insert(Faq faq)
        {
            _faqRepository.Insert(faq);
        }

        /// <summary>
        /// Update a faq.
        /// </summary>
        /// <param name="faq"></param>
        public void Update(Faq faq)
        {
            _faqRepository.Update(faq);
        }

        /// <summary>
        /// Delete a faq by faq entity.
        /// </summary>
        /// <param name="faq">Faq</param>
        public void Delete(Faq faq)
        {
            _faqRepository.Delete(faq);
        }

        /// <summary>
        /// Delete a faq by faq id.
        /// </summary>
        /// <param name="faqId">faq Id</param>
        public void Delete(int faqId)
        {
            _faqRepository.Delete(faqId);
        }
    }
}
