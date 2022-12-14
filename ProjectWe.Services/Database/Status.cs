using System;
using System.Collections.Generic;

namespace ProjectWe.Services.Database
{
    public partial class Status
    {
        public Status()
        {
            Projects = new HashSet<Project>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
