using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Controllers;
using ProjectWe.Model;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class CitiesController : BaseCRUDController<Model.City, CitySearchObject, CityUpsertRequest, CityUpsertRequest>
    {
        public CitiesController(ICitiesService service) : base(service)
        {
        }
    }
}
