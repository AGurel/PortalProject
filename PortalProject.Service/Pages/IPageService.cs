using PortalProject.Core.Domain.Entity;
using System.Linq;

namespace PortalProject.Service.Pages
{
    public interface IPageService
    {
        /// <summary>
        /// Get all pages.
        /// </summary>
        /// <returns></returns>
        IQueryable<Page> GetAll();

        /// <summary>
        /// Get top pages.
        /// </summary>
        /// <returns></returns>
        IQueryable<Page> GetUpPages();

       /// <summary>
       /// Get sub pages.
       /// </summary>
       /// <param name="UpPageId"></param>
       /// <returns></returns>
        IQueryable<Page> GetSubPages();

        /// <summary>
        /// Find page by id.
        /// </summary>
        /// <param name="pageId"></param>
        /// <returns></returns>
        Page Find(int pageId);

        /// <summary>
        /// Insert a new page.
        /// </summary>
        /// <param name="page"></param>
        void Insert(Page page);

        /// <summary>
        /// Update a setting.
        /// </summary>
        /// <param name="page"></param>
        void Update(Page page);

        /// <summary>
        /// Delete a setting by setting.
        /// </summary>
        /// <param name="page">Page</param>
        void Delete(Page page);

        /// <summary>
        /// Delete a page by page id.
        /// </summary>
        /// <param name="pageId"></param>
        void Delete(int pageId);
    }
}
