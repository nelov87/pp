using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Data
{
    public class Gallery
    {
        public string Id { get; set; }

        public string Name { get; set; }

        //public HashSet<Image> Images { get; set; }

       public ICollection<GalleryImage> GalleryImages { get; set; }


        public Gallery()
        {
            this.Id = Guid.NewGuid().ToString();
            //this.Images = new HashSet<Image>();
            this.GalleryImages = new HashSet<GalleryImage>();

        }

    }
}
