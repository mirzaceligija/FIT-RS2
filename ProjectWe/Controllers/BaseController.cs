using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Services;

namespace ProjectWe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase where T : class where TSearch : class
    {
        public IService<T, TSearch> Service { get; set; }

        public BaseController(IService<T, TSearch> service)
        {
            Service = service;
        }

        [HttpGet]
        public IEnumerable<T> GetList([FromQuery] TSearch search = null)
        {
            return Service.GetList(search);
        }

        [HttpGet("{id}")]
        public T Get(int id)
        {
            return Service.Get(id);
        }
    }
}
