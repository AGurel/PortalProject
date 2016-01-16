using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProject.Core.Domain.Entity
{
    [Table("Setting")]
    public class Setting : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string SMTPServer { get; set; }
        public int SMTPPort { get; set; }
        public bool SMTPSSL { get; set; }
        public string SMTPLogin { get; set; }
        public string SMTPPassword { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string Youtube { get; set; }
    }
}
