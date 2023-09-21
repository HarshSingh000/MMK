using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine.Types.MMK;
using MMK.Models;
using Kentico.Content.Web.Mvc;
using System.Reflection.Metadata;
namespace MMK.Models
{
    public class GalleryModel
    {
        public string ImageTitle { get; set; }
        public string Image { get; set; }
        public string ImageDescription { get; set; }
        public static GalleryModel Map(Gallery _gallery)
        {
            GalleryModel gallery = new GalleryModel();
            gallery.ImageTitle = _gallery.ImageTitle;
            gallery.Image = _gallery.Image;
            gallery.ImageDescription = _gallery.ImageDescription;
            return gallery;
        }

        public static GalleryModel Top3(Gallery _gallery)
        {
            GalleryModel gallery = new GalleryModel();
            gallery.ImageTitle = _gallery.ImageTitle;
            gallery.Image = _gallery.Image;
            gallery.ImageDescription = _gallery.ImageDescription;
            return gallery;
        }
    }
}
