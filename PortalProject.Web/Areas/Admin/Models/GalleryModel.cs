﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortalProject.Core.Domain.Entity;

namespace PortalProject.Web.Areas.Admin.Models
{
    public class GalleryModel
    {
        public List<GalleryAlbum> GalleryAlbumList { get; set; }
    }
}