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
    }
}
