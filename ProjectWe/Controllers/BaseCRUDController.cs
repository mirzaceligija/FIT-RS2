﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Services;

namespace ProjectWe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
        where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
        }

        [HttpPost]
        public T Insert([FromBody] TInsert insert)
        {
            var result = ((ICRUDService<T, TSearch, TInsert, TUpdate>)this.Service).Insert(insert);
            return result;
        }

        [HttpPut]
        public T Update(int id, [FromBody] TUpdate update)
        {
            var result = ((ICRUDService<T, TSearch, TInsert, TUpdate>)this.Service).Update(id, update);
            return result;
        }
    }
}
