using System;
using System.Collections.Generic;

namespace ProjectWe.Services.Database
{
    public partial class Budget
    {
        public int BudgetId { get; set; }
        public string Description { get; set; } = null!;
        public decimal CostPerUnit { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal? TotalCost { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int ActivityId { get; set; }

        public virtual Activity Activity { get; set; } = null!;
        public virtual Project Project { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
