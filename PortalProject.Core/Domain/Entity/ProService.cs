using PortalProject.Core.Enums.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProject.Core.Domain.Entity
{
    [Table("Service")]
    public class ProService : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string SeoUrl { get; set; }
        public State Active { get; set; }
        public int Order { get; set; }
    }
}
