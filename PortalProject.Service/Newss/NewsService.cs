using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System.Linq;

namespace PortalProject.Service.Newss
{
    public class NewsService : INewsService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<News> _newsRepository;

        public NewsService(IUnitOfWork uow)
        {
            _uow = uow;
            _newsRepository = uow.GetRepository<News>();
        }

        /// <summary>
        /// Get all news.
        /// </summary>
        /// <returns></returns>
        public IQueryable<News> GetAll()
        {
            return _newsRepository.GetAll().Where(x => x.Active == State.Active).OrderByDescending(x => x.Date);
        }
        
        /// <summary>
        /// Find news by news id
        /// </summary>
        /// <param name="newsId"></param>
        /// <returns></returns>
        public News Find(int newsId)
        {
            return _newsRepository.Find(newsId);
        }

        /// <summary>
        /// Insert new news.
        /// </summary>
        /// <param name="news"></param>
        public void Insert(News news)
        {
            _newsRepository.Insert(news);
        }

        /// <summary>
        /// Update a news.
        /// </summary>
        /// <param name="news"></param>
        public void Update(News news)
        {
            _newsRepository.Update(news);
        }

        /// <summary>
        /// Delete a news by news entity.
        /// </summary>
        /// <param name="news">News</param>
        public void Delete(News news)
        {
            _newsRepository.Delete(news);
        }

        /// <summary>
        /// Delete a news by news id.
        /// </summary>
        /// <param name="newsId">news Id</param>
        public void Delete(int newsId)
        {
            _newsRepository.Delete(newsId);
        }
    }
}
