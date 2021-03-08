
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Data
{
    public class Image
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public ICollection<GalleryImage> GalleryImages { get; set; }


        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
            //this.GalleryImages = new HashSet<GalleryImage>();
        }

    }
}
