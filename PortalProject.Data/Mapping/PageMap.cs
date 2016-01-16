using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class PageMap : EntityTypeConfiguration<Page>
    {
        public PageMap()
        {
            ToTable("Page");
            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(300);
            Property(x => x.SeoUrl).HasMaxLength(300);
        }
    }
}
