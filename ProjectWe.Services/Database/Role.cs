using System;
using System.Collections.Generic;

namespace ProjectWe.Services.Database
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
