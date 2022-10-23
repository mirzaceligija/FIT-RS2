using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.SearchObjects
{
    public class ActivitySearchObject : BaseSearchObject
    {
        public int ProjectId { get; set; }
        public int ObjectiveId { get; set; }
        public int OutputId { get; set; }
    }
}
