using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;
using ProjectWe.Services.Database;

namespace ProjectWe.Controllers
{
    public class UsersController : BaseCRUDController<Model.User, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {

        public UsersController(IUsersService service) : base(service)
        {
        }

        [AllowAnonymous]
        public override Model.User Insert([FromBody] UserInsertRequest insert)
        {
            return base.Insert(insert);
        }
    }
}
