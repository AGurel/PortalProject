using PortalProject.Core.Enums.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProject.Core.Domain.Entity
{
    [Table("News")]
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public DateTime? Date { get; set; }
        public string SeoUrl { get; set; }
        public State Active { get; set; }
        public string Creator { get; set; }
    }
}
