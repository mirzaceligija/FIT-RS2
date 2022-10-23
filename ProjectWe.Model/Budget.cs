using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model
{
    public partial class Budget
    {
        public int BudgetId { get; set; }
        public string Description { get; set; }
        public decimal CostPerUnit { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal? TotalCost { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int ActivityId { get; set; }
    }
}
