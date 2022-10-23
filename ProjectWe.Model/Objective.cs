using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model
{
    public partial class Objective
    {
        public int ObjectiveId { get; set; }
        public string ObjectiveNumber { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
    }
}
