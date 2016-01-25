using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;

namespace PortalProject.Web.Areas.Admin.Models
{
    public class BannerModel
    {
        public int Id { get; set; }
        public string TitleMain { get; set; }
        public string TitleSub { get; set; }
        public string Photo { get; set; }
        public string Url { get; set; }
        public string UrlTarget { get; set; }
        public State Active { get; set; }
        public int Order { get; set; }

        public List<Banner> BannerList { get; set; }
    }
}