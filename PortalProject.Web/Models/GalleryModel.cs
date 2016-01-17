using PortalProject.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalProject.Web.Models
{
    public class GalleryModel
    {
        public GalleryAlbum GalleryAlbum { get; set; }
        public List<GalleryAlbum> GalleryAlbumList { get; set; }
        public List<Gallery> GalleryList { get; set; }
    }
}