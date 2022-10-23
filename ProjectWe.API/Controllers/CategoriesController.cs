using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Model;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.Controllers
{
    public class CategoriesController : BaseCRUDController<Model.Category, CategorySearchObject, CategoryUpsertRequest, CategoryUpsertRequest>
    {
        public CategoriesController(ICategoriesService service) : base(service)
        {
        }

        [AllowAnonymous]
        public override IEnumerable<Category> GetList([FromQuery] CategorySearchObject search = null)
        {
            return base.GetList(search);
        }

        [AllowAnonymous]
        public override Category Get(int id)
        {
            return base.Get(id);
        }

        [Authorize("Administrator")]
        public override Category Insert([FromBody] CategoryUpsertRequest insert)
        {
            return base.Insert(insert);
        }


        [Authorize("Administrator")]
        public override Category Update(int id, [FromBody] CategoryUpsertRequest insert)
        {
            return base.Update(id, insert);
        }
    }
}
