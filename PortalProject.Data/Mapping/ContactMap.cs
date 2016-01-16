using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            ToTable("Contact");
            HasKey(x => x.Id);
            Property(x => x.Address).HasMaxLength(500);
            Property(x => x.Phone).HasMaxLength(40);
            Property(x => x.Email).HasMaxLength(100);
        }
    }
}
