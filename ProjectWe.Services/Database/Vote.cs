using System;
using System.Collections.Generic;

namespace ProjectWe.Services.Database
{
    public partial class Vote
    {
        public int VoteId { get; set; }
        public bool Positive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
