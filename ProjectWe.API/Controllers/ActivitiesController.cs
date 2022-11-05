using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Controllers;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class ActivitiesController : BaseCRUDController<Model.Activity, ActivitySearchObject, ActivityInsertRequest, ActivityUpdateRequest>
    {
        public ActivitiesController(IActivitiesService service) : base(service)
        {
        }

        [Authorize("Manager")]
        public override Model.Activity Get(int id)
        {
            return base.Get(id);
        }

        [Authorize("Manager")]
        public override Model.Activity Insert([FromBody] ActivityInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize("Manager")]
        public override Model.Activity Update(int id, [FromBody] ActivityUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
