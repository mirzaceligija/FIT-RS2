using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Controllers;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class OutputsController : BaseCRUDController<Model.Output, OutputSearchObject, OutputInsertRequest, OutputUpdateRequest>
    {
        public OutputsController(IOutputsService service) : base(service)
        {
        }

        [Authorize("Manager")]
        public override Model.Output Get(int id)
        {
            return base.Get(id);
        }

        [Authorize("Manager")]
        public override Model.Output Insert([FromBody] OutputInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize("Manager")]
        public override Model.Output Update(int id, [FromBody] OutputUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
