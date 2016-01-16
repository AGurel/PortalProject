using PortalProject.Core.Domain.Entity;
using System.Linq;

namespace PortalProject.Service.Galleries
{
    public interface IGalleryService
    {
        /// <summary>
        /// Get all galleries.
        /// </summary>
        /// <returns></returns>
        IQueryable<Gallery> GetAll();

        /// <summary>
        /// Get random galleries with count.
        /// </summary>
        /// <param name="galleryCount"></param>
        /// <returns></returns>
        IQueryable<Gallery> GetRandomGalleries(int galleryCount);

        /// <summary>
        /// Get galleries by Gallery Album Id
        /// </summary>
        /// <param name="GalleryAlbumId"></param>
        /// <returns></returns>
        IQueryable<Gallery> GetGalleriesByGalleryAlbum(int GalleryAlbumId);

        /// <summary>
        /// Find gallery by id.
        /// </summary>
        /// <param name="galleryId"></param>
        /// <returns></returns>
        Gallery Find(int galleryId);

        /// <summary>
        /// Insert a new gallery.
        /// </summary>
        /// <param name="gallery"></param>
        void Insert(Gallery gallery);

        /// <summary>
        /// Update a gallery.
        /// </summary>
        /// <param name="gallery"></param>
        void Update(Gallery gallery);

        /// <summary>
        /// Delete a gallery by gallery.
        /// </summary>
        /// <param name="gallery">Gallery</param>
        void Delete(Gallery gallery);

        /// <summary>
        /// Delete a gallery by gallery id.
        /// </summary>
        /// <param name="galleryId"></param>
        void Delete(int galleryId);
    }
}
