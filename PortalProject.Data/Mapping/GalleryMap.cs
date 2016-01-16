using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class GalleryMap : EntityTypeConfiguration<Gallery>
    {
        public GalleryMap()
        {
            ToTable("Gallery");
            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(150);
            Property(x => x.Content).HasMaxLength(1000);
            Property(x => x.Photo).HasMaxLength(750);

            HasMany(h => h.GalleryAlbums).
            WithMany(e => e.Galleries).
            Map(
            m =>
            {
                m.MapLeftKey("GalleryId");
                m.MapRightKey("GalleryAlbumId");
                m.ToTable("GalleryInGalleryAlbum");
            }
            );
        }
    }
}
