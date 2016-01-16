using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProject.Core.Domain.Entity
{
    [Table("Contact")]
    public class Contact : BaseEntity
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Map { get; set; }
    }
}
