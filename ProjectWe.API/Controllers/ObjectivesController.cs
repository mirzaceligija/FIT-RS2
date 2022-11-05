using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Controllers;
using ProjectWe.Model;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class ObjectivesController : BaseCRUDController<Model.Objective, ObjectiveSearchObject, ObjectiveInsertRequest, ObjectiveUpdateRequest>
    {
        public ObjectivesController(IObjectivesService service) : base(service)
        {
        }

        [Authorize("Manager")]
        public override Objective Get(int id)
        {
            return base.Get(id);
        }

        [Authorize("Manager")]
        public override Objective Insert([FromBody] ObjectiveInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize("Manager")]
        public override Objective Update(int id, [FromBody] ObjectiveUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
