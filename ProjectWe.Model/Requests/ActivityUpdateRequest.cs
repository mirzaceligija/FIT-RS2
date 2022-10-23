using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.Requests
{
    public class ActivityUpdateRequest
    {
        public string ActivityNumber { get; set; }
        public string Description { get; set; }
        public string Locations { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string DirectBeneficiaries { get; set; }
        public string IndirectBeneficiaries { get; set; }
        public int OutputId { get; set; }
    }
}
