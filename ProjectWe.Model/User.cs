using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWe.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public string RoleNames => string.Join(", ", UserRoles?.Select(x => x.Role?.Name)?.ToList());
    }
}
