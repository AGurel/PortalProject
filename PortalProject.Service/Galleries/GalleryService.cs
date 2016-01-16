using PortalProject.Core.Domain.Entity;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System;
using System.Linq;

namespace PortalProject.Service.Galleries
{
    public class GalleryService : IGalleryService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Gallery> _galleryRepository;
        private readonly IGenericRepository<GalleryAlbum> _galleryAlbumRepository;

        public GalleryService(IUnitOfWork uow)
        {
            _uow = uow;
            _galleryRepository = uow.GetRepository<Gallery>();
            _galleryAlbumRepository = uow.GetRepository<GalleryAlbum>();
        }

        /// <summary>
        /// Get all galleries.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Gallery> GetAll()
        {
            return _galleryRepository.GetAll();
        }

        /// <summary>
        /// Get random galleries with count.
        /// </summary>
        /// <param name="galleryCount"></param>
        /// <returns></returns>
        public IQueryable<Gallery> GetRandomGalleries(int galleryCount)
        {
            return _galleryRepository.GetAll().OrderBy(r => Guid.NewGuid()).Take(galleryCount);
        }

        /// <summary>
        /// Get galleries by Gallery Album Id
        /// </summary>
        /// <param name="GalleryAlbumId"></param>
        /// <returns></returns>
        public IQueryable<Gallery> GetGalleriesByGalleryAlbum(int GalleryAlbumId)
        {
            return _galleryAlbumRepository.GetAll().FirstOrDefault(x => x.Id == GalleryAlbumId).Galleries.AsQueryable();
        }

        /// <summary>
        /// Find gallery by gallery id
        /// </summary>
        /// <param name="galleryId"></param>
        /// <returns></returns>
        public Gallery Find(int galleryId)
        {
            return _galleryRepository.Find(galleryId);
        }

        /// <summary>
        /// Insert new gallery.
        /// </summary>
        /// <param name="gallery"></param>
        public void Insert(Gallery gallery)
        {
            _galleryRepository.Insert(gallery);
        }

        /// <summary>
        /// Update a gallery.
        /// </summary>
        /// <param name="gallery"></param>
        public void Update(Gallery gallery)
        {
            _galleryRepository.Update(gallery);
        }

        /// <summary>
        /// Delete a gallery by gallery entity.
        /// </summary>
        /// <param name="gallery">Gallery</param>
        public void Delete(Gallery gallery)
        {
            _galleryRepository.Delete(gallery);
        }

        /// <summary>
        /// Delete a gallery by gallery id.
        /// </summary>
        /// <param name="galleryId">Gallery Id</param>
        public void Delete(int galleryId)
        {
            _galleryRepository.Delete(galleryId);
        }
    }
}
