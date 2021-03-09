using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Data
{
    public class Project
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string GalleryId { get; set; }
        public Gallery Gallery { get; set; }

        public string ImageId { get; set; }
        public Image Image { get; set; }

        public Project()
        {
            this.Id = Guid.NewGuid().ToString();
            
        }
    }
}
