using System.Linq;

namespace PortalProject.Data.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get all records.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Find record by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Find(int id);
        
        /// <summary>
        /// Insert a new record.
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Update a new record.
        /// </summary>
        /// <param name="entityToUpdate"></param>
        void Update(TEntity entityToUpdate);

        /// <summary>
        /// Delete a record by id.
        /// </summary>
        /// <param name="id">Record Id</param>
        void Delete(int id);

        /// <summary>
        /// Delete a record by entity.
        /// </summary>
        /// <param name="entityToDelete">Record</param>
        void Delete(TEntity entityToDelete);
    }
}
