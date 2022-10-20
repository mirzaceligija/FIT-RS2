using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.Requests
{
    public class ProjectUpdateRequest
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public int CategoryId { get; set; }
    }
}
