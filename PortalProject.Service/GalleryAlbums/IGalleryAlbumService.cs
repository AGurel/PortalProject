using PortalProject.Core.Domain.Entity;
using System.Linq;

namespace PortalProject.Service.GalleryAlbums
{
    public interface IGalleryAlbumService
    {
        /// <summary>
        /// Get all gallery albums.
        /// </summary>
        /// <returns></returns>
        IQueryable<GalleryAlbum> GetAll();

        /// <summary>
        /// Get gallery albums by gallery id.
        /// </summary>
        /// <param name="GalleryId"></param>
        /// <returns></returns>
        IQueryable<GalleryAlbum> GetGalleryAlbumsByGallery(int GalleryId);

        /// <summary>
        /// Find gallery album by id.
        /// </summary>
        /// <param name="galleryAlbumId"></param>
        /// <returns></returns>
        GalleryAlbum Find(int galleryAlbumId);

        /// <summary>
        /// Insert a new gallery album.
        /// </summary>
        /// <param name="galleryAlbum"></param>
        void Insert(GalleryAlbum galleryAlbum);

        /// <summary>
        /// Update a gallery album.
        /// </summary>
        /// <param name="galleryAlbum"></param>
        void Update(GalleryAlbum galleryAlbum);

        /// <summary>
        /// Delete a gallery album by setting.
        /// </summary>
        /// <param name="galleryAlbum">Gallery Album</param>
        void Delete(GalleryAlbum galleryAlbum);

        /// <summary>
        /// Delete a gallery album by setting id.
        /// </summary>
        /// <param name="galleryAlbumId"></param>
        void Delete(int galleryAlbumId);
    }
}
