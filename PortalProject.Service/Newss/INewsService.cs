using PortalProject.Core.Domain.Entity;
using System.Linq;

namespace PortalProject.Service.Newss
{
    public interface INewsService
    {
        /// <summary>
        /// Get all news.
        /// </summary>
        /// <returns></returns>
        IQueryable<News> GetAll();

        /// <summary>
        /// Find news by id.
        /// </summary>
        /// <param name="newsId"></param>
        /// <returns></returns>
        News Find(int newsId);

        /// <summary>
        /// Insert a new news.
        /// </summary>
        /// <param name="news"></param>
        void Insert(News news);

        /// <summary>
        /// Update a news.
        /// </summary>
        /// <param name="news"></param>
        void Update(News news);

        /// <summary>
        /// Delete a news by news.
        /// </summary>
        /// <param name="news">News</param>
        void Delete(News news);

        /// <summary>
        /// Delete a news by news id.
        /// </summary>
        /// <param name="newsId"></param>
        void Delete(int newsId);
    }
}
