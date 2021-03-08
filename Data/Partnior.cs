using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Data
{
    public class Partnior
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public Image Image { get; set; }

        public Gallery Galery { get; set; }


        public Partnior()
        {
            this.Id = Guid.NewGuid().ToString();
            
        }
    }
}
