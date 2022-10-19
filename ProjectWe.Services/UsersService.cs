using AutoMapper;
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
        public IMapper Mapper { get; set; }
        public UsersService(_160020Context context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public IEnumerable<Model.User> Get()
        {
            var result = Context.Users.ToList();
            return Mapper.Map<List<Model.User>>(result) ;
        }
    }
}
