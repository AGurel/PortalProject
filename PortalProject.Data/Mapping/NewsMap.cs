using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class NewsMap : EntityTypeConfiguration<News>
    {
        public NewsMap()
        {
            ToTable("News");
            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(200);
        }
    }
}
