using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class BannerMap : EntityTypeConfiguration<Banner>
    {
        public BannerMap()
        {
            ToTable("Banner");
            HasKey(x => x.Id);
            Property(x => x.TitleMain).HasMaxLength(150);
            Property(x => x.TitleSub).HasMaxLength(150);
            Property(x => x.Photo).HasMaxLength(750);
            Property(x => x.Url).HasMaxLength(150);
            Property(x => x.UrlTarget).HasMaxLength(20);
        }
    }
}
