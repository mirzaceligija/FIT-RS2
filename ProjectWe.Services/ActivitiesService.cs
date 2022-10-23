using AutoMapper;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class ActivitiesService : BaseCRUDService<Model.Activity, Database.Activity, ActivitySearchObject, ActivityInsertRequest, ActivityUpdateRequest>, IActivitiesService
    {
        public ActivitiesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
