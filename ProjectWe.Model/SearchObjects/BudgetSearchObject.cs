using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.SearchObjects
{
    public class BudgetSearchObject : BaseSearchObject
    {
        public int ProjectId { get; set; }
        public int ObjectiveId { get; set; }
        public int OutputId { get; set; }
        public int ActivityId { get; set; }
    }
}
