using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;

namespace PortalProject.Web.Areas.Admin.Models
{
    public class ProServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public State Active { get; set; }
        public int Order { get; set; }

        public List<ProService> ProServiceList { get; set; }
    }
}