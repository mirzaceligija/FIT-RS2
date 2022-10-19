using System;
using System.Collections.Generic;

namespace ProjectWe.Services.Database
{
    public partial class Category
    {
        public Category()
        {
            Projects = new HashSet<Project>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
