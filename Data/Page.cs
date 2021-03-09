using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Data
{
    public class Page
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public Image Image { get; set; }

        public Gallery Gallery { get; set; }

        public Page()
        {
            this.Id = Guid.NewGuid().ToString();
            
            
        }
    }
}
