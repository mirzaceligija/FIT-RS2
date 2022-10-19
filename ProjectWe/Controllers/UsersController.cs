using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Services;
using ProjectWe.Services.Database;

namespace ProjectWe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _Service;

        public UsersController(IUsersService service)
        {
            _Service = service;
        }

        [HttpGet]
        public IEnumerable<Model.User> Get()
        {
            return _Service.Get();
        }
    }
}
