using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public interface ICitiesService : ICRUDService<Model.City, CitySearchObject, CityUpsertRequest, CityUpsertRequest>
    {
    }
}
