using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.SearchObjects
{
    public class CategorySearchObject : BaseSearchObject
    {
        public string Name { get; set; }
        public int? CategoryId { get; set; }
    }
}
