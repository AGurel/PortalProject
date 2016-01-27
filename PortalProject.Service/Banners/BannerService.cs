using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System.Linq;

namespace PortalProject.Service.Banners
{
    public class BannerService : IBannerService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Banner> _bannerRepository;

        public BannerService(IUnitOfWork uow)
        {
            _uow = uow;
            _bannerRepository = uow.GetRepository<Banner>();
        }

        /// <summary>
        /// Get all active banners order by Order Column asc.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Banner> GetAll()
        {
            return _bannerRepository.GetAll().OrderBy(x => x.Order);
        }
        
        /// <summary>
        /// Find banner by banner id
        /// </summary>
        /// <param name="bannerId"></param>
        /// <returns></returns>
        public Banner Find(int bannerId)
        {
            return _bannerRepository.Find(bannerId);
        }

        /// <summary>
        /// Insert new banner.
        /// </summary>
        /// <param name="banner"></param>
        public void Insert(Banner banner)
        {
            _bannerRepository.Insert(banner);
        }

        /// <summary>
        /// Update a banner.
        /// </summary>
        /// <param name="banner"></param>
        public void Update(Banner banner)
        {
            _bannerRepository.Update(banner);
        }

        /// <summary>
        /// Delete a banner by banner entity.
        /// </summary>
        /// <param name="banner">Banner</param>
        public void Delete(Banner banner)
        {
            _bannerRepository.Delete(banner);
        }

        /// <summary>
        /// Delete a banner by banner id.
        /// </summary>
        /// <param name="bannerId">Banner Id</param>
        public void Delete(int bannerId)
        {
            _bannerRepository.Delete(bannerId);
        }
    }
}
