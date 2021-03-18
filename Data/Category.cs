using System.Collections.Generic;
using System;
namespace INStudio.Data
{
    public class Category
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public ICollection<CategoryProject> CategoryProject { get; set; }

        public Category()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CategoryProject = new HashSet<CategoryProject>();
        }
    }
}