using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
