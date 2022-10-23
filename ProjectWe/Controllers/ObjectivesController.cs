using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Controllers;
using ProjectWe.Model;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectivesController : BaseCRUDController<Model.Objective, ObjectiveSearchObject, ObjectiveInsertRequest, ObjectiveUpdateRequest>
    {
        public ObjectivesController(IObjectivesService service) : base(service)
        {
        }
    }
}
