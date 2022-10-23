using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.Requests
{
    public class BudgetUpdateRequest
    {
        public string Description { get; set; }
        public decimal CostPerUnit { get; set; }
        public int NumberOfUnits { get; set; }
        public int ActivityId { get; set; }
    }
}
