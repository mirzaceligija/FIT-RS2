using System;
using System.Collections.Generic;

namespace ProjectWe.Services.Database
{
    public partial class Objective
    {
        public Objective()
        {
            Outputs = new HashSet<Output>();
        }

        public int ObjectiveId { get; set; }
        public string ObjectiveNumber { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Output> Outputs { get; set; }
    }
}
