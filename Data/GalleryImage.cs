using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Data
{
    public class GalleryImage
    {
        public string GalleryId { get; set; }
        public Gallery Gallery { get; set; }

        public string ImageId { get; set; }
        public Image Image { get; set; }
    }
}
