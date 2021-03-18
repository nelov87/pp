using System.Collections.Generic;
using System;
namespace INStudio.Data
{
    public class CategoryProject
    {
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public string ProjectId { get; set; }
        public Project Project { get; set; }
    }
}