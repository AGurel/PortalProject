using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class GalleryAlbumMap : EntityTypeConfiguration<GalleryAlbum>
    {
        public GalleryAlbumMap()
        {
            ToTable("GalleryAlbum");
            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(150);
            Property(x => x.Photo).HasMaxLength(750);
            Property(x => x.SeoUrl).HasMaxLength(300);
        }
    }
}
