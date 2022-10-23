using ProjectWe.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model
{
    public class OutputSearchObject : BaseSearchObject
    {
        public int ProjectId { get; set; }
        public int ObjectiveId { get; set; }
    }
}
