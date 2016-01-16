using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class FaqMap : EntityTypeConfiguration<Faq>
    {
        public FaqMap()
        {
            ToTable("Faq");
            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(300);
        }
    }
}
