using PortalProject.Core.Domain.Entity;
using System.Linq;

namespace PortalProject.Service.ProServices
{
    public interface IProServiceService
    {
        /// <summary>
        /// Get all proservices.
        /// </summary>
        /// <returns></returns>
        IQueryable<ProService> GetAll();

        /// <summary>
        /// Find proservice by id.
        /// </summary>
        /// <param name="proServiceId"></param>
        /// <returns></returns>
        ProService Find(int proServiceId);

        /// <summary>
        /// Insert a new proservice.
        /// </summary>
        /// <param name="proService"></param>
        void Insert(ProService setting);

        /// <summary>
        /// Update a proservice.
        /// </summary>
        /// <param name="setting"></param>
        void Update(ProService setting);

        /// <summary>
        /// Delete a proservice by proservice.
        /// </summary>
        /// <param name="setting">Setting</param>
        void Delete(ProService setting);

        /// <summary>
        /// Delete a proservice by proservice id.
        /// </summary>
        /// <param name="proServiceId"></param>
        void Delete(int proServiceId);
    }
}
