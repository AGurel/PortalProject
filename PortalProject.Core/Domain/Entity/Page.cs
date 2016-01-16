using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProject.Core.Domain.Entity
{
    [Table("Page")]
    public class Page : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string SeoUrl { get; set; }
        public int UpPageId { get; set; }
        public int Active { get; set; }
        public int Order { get; set; }
    }
}
