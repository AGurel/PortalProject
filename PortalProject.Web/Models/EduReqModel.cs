using System.Collections.Generic;
using PortalProject.Core.Domain.Entity;

namespace PortalProject.Web.Models
{
    public class EduReqModel
    {
        public string frmNameSurname { get; set; }
        public string frmEMail { get; set; }
        public string frmPhone { get; set; }
        public string frmCity { get; set; }
        public string frmCityOther { get; set; }
        public string frmDate { get; set; }
        public string frmDateOther { get; set; }
        public string frmCompany { get; set; }
        public string frmJob { get; set; }
        public string frmMessage { get; set; }
    }
}