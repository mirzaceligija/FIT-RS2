using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class UsersService : IUsersService
    {
        public _160020Context Context { get; set; }
        public UsersService(_160020Context context)
        {
            Context = context;
        }

        public IEnumerable<Model.User> Get()
        {
            List<Model.User> users = new List<Model.User>();

            var result = Context.Users.ToList();

            foreach (var item in result)
            {
                users.Add(new Model.User() { FirstName=item.FirstName, LastName=item.LastName, Username=item.Username, UserId=item.UserId, Email=item.Email, Phone=item.Phone }); ;
            }

            return users;
        }
    }
}
