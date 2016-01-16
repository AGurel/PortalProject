using PortalProject.Core.Domain.Entity;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System.Linq;

namespace PortalProject.Service.GalleryAlbums
{
    public class GalleryAlbumService : IGalleryAlbumService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<GalleryAlbum> _galleryAlbumRepository;
        private readonly IGenericRepository<Gallery> _galleryRepository;

        public GalleryAlbumService(IUnitOfWork uow)
        {
            _uow = uow;
            _galleryAlbumRepository = uow.GetRepository<GalleryAlbum>();
            _galleryRepository = uow.GetRepository<Gallery>();
        }

        /// <summary>
        /// Get all gallery albums.
        /// </summary>
        /// <returns></returns>
        public IQueryable<GalleryAlbum> GetAll()
        {
            return _galleryAlbumRepository.GetAll();
        }

        /// <summary>
        /// Get gallery albums by gallery id.
        /// </summary>
        /// <param name="GalleryId"></param>
        /// <returns></returns>
        public IQueryable<GalleryAlbum> GetGalleryAlbumsByGallery(int GalleryId)
        {
            return _galleryRepository.GetAll().FirstOrDefault(x=>x.Id == GalleryId).GalleryAlbums.AsQueryable();
        }
        
        /// <summary>
        /// Find gallery album by gallery album id
        /// </summary>
        /// <param name="galleryAlbumId"></param>
        /// <returns></returns>
        public GalleryAlbum Find(int galleryAlbumId)
        {
            return _galleryAlbumRepository.Find(galleryAlbumId);
        }

        /// <summary>
        /// Insert new gallery album.
        /// </summary>
        /// <param name="galleryAlbum"></param>
        public void Insert(GalleryAlbum galleryAlbum)
        {
            _galleryAlbumRepository.Insert(galleryAlbum);
        }

        /// <summary>
        /// Update a gallery album.
        /// </summary>
        /// <param name="galleryAlbum"></param>
        public void Update(GalleryAlbum galleryAlbum)
        {
            _galleryAlbumRepository.Update(galleryAlbum);
        }

        /// <summary>
        /// Delete a gallery album by gallery album entity.
        /// </summary>
        /// <param name="galleryAlbum">galleryAlbum</param>
        public void Delete(GalleryAlbum galleryAlbum)
        {
            _galleryAlbumRepository.Delete(galleryAlbum);
        }

        /// <summary>
        /// Delete a gallery album by gallery album id.
        /// </summary>
        /// <param name="galleryAlbumId">Gallery Album Id</param>
        public void Delete(int galleryAlbumId)
        {
            _galleryAlbumRepository.Delete(galleryAlbumId);
        }
    }
}
