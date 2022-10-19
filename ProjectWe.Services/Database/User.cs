using System;
using System.Collections.Generic;

namespace ProjectWe.Services.Database
{
    public partial class User
    {
        public User()
        {
            Activities = new HashSet<Activity>();
            Budgets = new HashSet<Budget>();
            Objectives = new HashSet<Objective>();
            Outputs = new HashSet<Output>();
            Projects = new HashSet<Project>();
            UserRoles = new HashSet<UserRole>();
            Votes = new HashSet<Vote>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string Username { get; set; } = null!;
        public string LozinkaHash { get; set; } = null!;
        public string LozinkaSalt { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Objective> Objectives { get; set; }
        public virtual ICollection<Output> Outputs { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
