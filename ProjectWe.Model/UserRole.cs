using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model
{
    public partial class UserRole
    {
        public int UserRolesId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime? LastModified { get; set; }
        public virtual Role Role { get; set; }
    }
}
