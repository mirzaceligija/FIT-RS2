using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.Requests
{
    public class ProjectUpdateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public int CityId { get; set; }
        public int CategoryId { get; set; }
    }
}
