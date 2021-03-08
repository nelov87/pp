using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Data
{
    public class Setting
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }


        public Setting()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
