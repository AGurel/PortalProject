using PortalProject.Core.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace PortalProject.Data.Mapping
{
    public class SettingMap : EntityTypeConfiguration<Setting>
    {
        public SettingMap()
        {
            ToTable("Setting");
            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(60);
            Property(x => x.Description).HasMaxLength(160);
            Property(x => x.SMTPServer).HasMaxLength(100);
            Property(x => x.SMTPLogin).HasMaxLength(100);
            Property(x => x.SMTPPassword).HasMaxLength(100);
            Property(x => x.Facebook).HasMaxLength(300);
            Property(x => x.Twitter).HasMaxLength(100);
            Property(x => x.LinkedIn).HasMaxLength(100);
            Property(x => x.Youtube).HasMaxLength(100);
        }
    }
}
