using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;

namespace PortalProject.Web.Areas.Admin.Models
{
    public class PageModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UpPageId { get; set; }
        public State Active { get; set; }
        public int Order { get; set; }

        public List<Page> PageList { get; set; }
    }
}