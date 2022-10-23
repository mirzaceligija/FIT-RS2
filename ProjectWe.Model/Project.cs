using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public int CategoryId { get; set; }
        public string StateMachine { get; set; }
    }
}
