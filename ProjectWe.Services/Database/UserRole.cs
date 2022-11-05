﻿using System;
using System.Collections.Generic;

namespace ProjectWe.Services.Database
{
    public partial class UserRole
    {
        public int UserRolesId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
