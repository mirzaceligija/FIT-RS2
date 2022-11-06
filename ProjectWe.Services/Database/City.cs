using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public partial class City
    {
        public City()
        {
            Projects = new HashSet<Project>();
        }

        public int CityId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Project> Projects { get; set; }
    }
}
