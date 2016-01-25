using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortalProject.Core.Domain.Entity;
using PortalProject.Core.Enums.Common;

namespace PortalProject.Web.Areas.Admin.Models
{
    public class NewsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public DateTime? Date { get; set; }
        public State Active { get; set; }
        public string Creator { get; set; }

        public List<News> NewsList { get; set; }
    }
}