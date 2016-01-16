using PortalProject.Core.Enums.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProject.Core.Domain.Entity
{
    [Table("Faq")]
    public class Faq : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public State Active { get; set; }
        public int Order { get; set; }
    }
}
