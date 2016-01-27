using PortalProject.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalProject.Web.Areas.Admin.Models
{
    public class SettingModel
    {
        public int Id { get; set; }
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

        public List<Setting> SettingList { get; set; }
    }
}