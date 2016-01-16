using PortalProject.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalProject.Web.Models
{
    public class NewsModel
    {
        public News News { get; set; }
        public List<News> NewsList { get; set; }
    }
}