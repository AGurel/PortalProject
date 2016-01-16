using System.ComponentModel.DataAnnotations.Schema;
using PortalProject.Core.Enums.Common;

namespace PortalProject.Core.Domain.Entity
{
    [Table("Banner")]
    public class Banner : BaseEntity
    {
        public string TitleMain { get; set; }
        public string TitleSub { get; set; }
        public string Photo { get; set; }
        public string Url { get; set; }
        public string UrlTarget { get; set; }
        public State Active { get; set; }
        public int Order { get; set; }
    }
}
