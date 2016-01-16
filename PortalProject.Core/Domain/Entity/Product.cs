using PortalProject.Core.Enums.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProject.Core.Domain.Entity
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public State Active { get; set; }
        public int Order { get; set; }
    }
}
