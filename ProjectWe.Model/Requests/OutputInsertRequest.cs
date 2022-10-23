using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.Requests
{
    public class OutputInsertRequest
    {
        public string OutputNumber { get; set; }
        public string Description { get; set; }
        public string Indicators { get; set; }
        public string MeansOfVerification { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int ObjectiveId { get; set; }
    }
}
