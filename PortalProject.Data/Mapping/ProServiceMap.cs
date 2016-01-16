using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class ProServiceMap : EntityTypeConfiguration<ProService>
    {
        public ProServiceMap()
        {
            ToTable("ProService");
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(100);
            Property(x => x.IconClass).HasMaxLength(50);
            Property(x => x.SeoUrl).HasMaxLength(300);
        }
    }
}
