using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System.Linq;

namespace PortalProject.Service.Pages
{
    public class PageService : IPageService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Page> _pageRepository;

        public PageService(IUnitOfWork uow)
        {
            _uow = uow;
            _pageRepository = uow.GetRepository<Page>();
        }

        /// <summary>
        /// Get all pages.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Page> GetAll()
        {
            return _pageRepository.GetAll().OrderBy(x => x.Order);
        }

        /// <summary>
        /// Get top pages.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Page> GetUpPages()
        {
            return _pageRepository.GetAll().Where(x => x.UpPageId == 0).OrderBy(x => x.Order);
        }

        /// <summary>
        /// Get sub pages.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Page> GetSubPages()
        {
            return _pageRepository.GetAll().Where(x => x.UpPageId != 0).OrderBy(x => x.Order);
        }
        
        /// <summary>
        /// Find Page by page id
        /// </summary>
        /// <param name="pageId"></param>
        /// <returns></returns>
        public Page Find(int pageId)
        {
            return _pageRepository.Find(pageId);
        }

        /// <summary>
        /// Insert new page.
        /// </summary>
        /// <param name="page"></param>
        public void Insert(Page page)
        {
            _pageRepository.Insert(page);
        }

        /// <summary>
        /// Update a page.
        /// </summary>
        /// <param name="page"></param>
        public void Update(Page page)
        {
            _pageRepository.Update(page);
        }

        /// <summary>
        /// Delete a page by page entity.
        /// </summary>
        /// <param name="page">page</param>
        public void Delete(Page page)
        {
            _pageRepository.Delete(page);
        }

        /// <summary>
        /// Delete a page by page id.
        /// </summary>
        /// <param name="pageId">page Id</param>
        public void Delete(int pageId)
        {
            _pageRepository.Delete(pageId);
        }
    }
}
