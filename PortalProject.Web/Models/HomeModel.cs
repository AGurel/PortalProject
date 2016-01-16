using System.Collections.Generic;
using PortalProject.Core.Domain.Entity;

namespace PortalProject.Web.Models
{
    public class HomeModel
    {
        public List<Banner> BannerList { get; set; }
        public List<Product> ProductList { get; set; }
        public List<ProService> ProServiceList { get; set; }
        public List<News> NewsList { get; set; }
        public List<Faq> FaqList { get; set; }
        public List<Gallery> GalleryList { get; set; }
    }
}