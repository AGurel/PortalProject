using System.Collections.Generic;
using PortalProject.Core.Domain.Entity;

namespace PortalProject.Web.Models
{
    public class ContactModel
    {
        public string frmName { get; set; }
        public string frmSurname { get; set; }
        public string frmEMail { get; set; }
        public string frmPhone { get; set; }
        public string frmMessage { get; set; }

    }
}