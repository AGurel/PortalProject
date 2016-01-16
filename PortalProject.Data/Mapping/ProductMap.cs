using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(50);
            Property(x => x.Name).HasMaxLength(300);
        }
    }
}
