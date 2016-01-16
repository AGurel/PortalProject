using PortalProject.Core.Domain.Entity;
using PortalProject.Data.Mapping;
using System.Data.Entity;

namespace PortalProject.Data.Context
{
    public class PortalProjectContext : DbContext
    {
        public PortalProjectContext()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Setting> Setting { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProService> Service { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<GalleryAlbum> GalleryAlbum { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SettingMap());
            modelBuilder.Configurations.Add(new PageMap());
            modelBuilder.Configurations.Add(new BannerMap());
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProServiceMap());
            modelBuilder.Configurations.Add(new NewsMap());
            modelBuilder.Configurations.Add(new FaqMap());
            modelBuilder.Configurations.Add(new GalleryMap());
            modelBuilder.Configurations.Add(new GalleryAlbumMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
