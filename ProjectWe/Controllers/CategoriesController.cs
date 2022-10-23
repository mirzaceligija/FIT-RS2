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
        public CategoriesController(ICategoryService service) : base(service)
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
    }
}
