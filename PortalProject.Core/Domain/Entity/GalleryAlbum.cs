using System.ComponentModel.DataAnnotations.Schema;
using PortalProject.Core.Enums.Common;
using System.Collections.Generic;

namespace PortalProject.Core.Domain.Entity
{
    [Table("GalleryAlbum")]
    public class GalleryAlbum : BaseEntity
    {
        public GalleryAlbum()
        {
            Galleries = new HashSet<Gallery>();
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public State Active { get; set; }
        public int Order { get; set; }
        public virtual ICollection<Gallery> Galleries { get; set; }
    }
}
