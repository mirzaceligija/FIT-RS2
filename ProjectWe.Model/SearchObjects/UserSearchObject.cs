using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWe.Model.SearchObjects
{
    public class UserSearchObject : BaseSearchObject
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IncludeRoles { get; set; }
    }
}
