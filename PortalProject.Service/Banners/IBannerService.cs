using PortalProject.Core.Domain.Entity;
using System.Linq;

namespace PortalProject.Service.Banners
{
    public interface IBannerService
    {
        /// <summary>
        /// Get all banners.
        /// </summary>
        /// <returns></returns>
        IQueryable<Banner> GetAll();

        /// <summary>
        /// Find banner by id.
        /// </summary>
        /// <param name="bannerId"></param>
        /// <returns></returns>
        Banner Find(int bannerId);

        /// <summary>
        /// Insert a new banner.
        /// </summary>
        /// <param name="banner"></param>
        void Insert(Banner banner);

        /// <summary>
        /// Update a banner.
        /// </summary>
        /// <param name="banner"></param>
        void Update(Banner banner);

        /// <summary>
        /// Delete a banner by banner.
        /// </summary>
        /// <param name="banner">Banner</param>
        void Delete(Banner banner);

        /// <summary>
        /// Delete a banner by banner id.
        /// </summary>
        /// <param name="bannerId"></param>
        void Delete(int bannerId);
    }
}
