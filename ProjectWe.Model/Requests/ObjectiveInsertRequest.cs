using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.Requests
{
    public class ObjectiveInsertRequest
    {
        public string ObjectiveNumber { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
    }
}
