using PortalProject.Core.Domain.Entity;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System.Linq;

namespace PortalProject.Service.ProServices
{
    public class ProServiceService : IProServiceService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<ProService> _proserviceRepository;

        public ProServiceService(IUnitOfWork uow)
        {
            _uow = uow;
            _proserviceRepository = uow.GetRepository<ProService>();
        }

        /// <summary>
        /// Get all proservices.
        /// </summary>
        /// <returns></returns>
        public IQueryable<ProService> GetAll()
        {
            return _proserviceRepository.GetAll();
        }

        /// <summary>
        /// Find proservice by proservice id.
        /// </summary>
        /// <param name="proServiceId"></param>
        /// <returns></returns>
        public ProService Find(int proServiceId)
        {
            return _proserviceRepository.Find(proServiceId);
        }

        /// <summary>
        /// Insert new proservice.
        /// </summary>
        /// <param name="proService"></param>
        public void Insert(ProService proService)
        {
            _proserviceRepository.Insert(proService);
        }

        /// <summary>
        /// Update a proservice.
        /// </summary>
        /// <param name="proService"></param>
        public void Update(ProService proService)
        {
            _proserviceRepository.Update(proService);
        }

        /// <summary>
        /// Delete a proservice by proservice entity.
        /// </summary>
        /// <param name="proService">proService</param>
        public void Delete(ProService proService)
        {
            _proserviceRepository.Delete(proService);
        }

        /// <summary>
        /// Delete a proservice by proservice id.
        /// </summary>
        /// <param name="proServiceId">Proservice Id</param>
        public void Delete(int proServiceId)
        {
            _proserviceRepository.Delete(proServiceId);
        }
    }
}
