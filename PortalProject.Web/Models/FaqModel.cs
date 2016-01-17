using PortalProject.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalProject.Web.Models
{
    public class FaqModel
    {
        public Faq Faq { get; set; }
        public List<Faq> FaqList { get; set; }
    }
}