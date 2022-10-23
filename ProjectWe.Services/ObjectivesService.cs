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
    public class ObjectivesService : BaseCRUDService<Model.Objective, Database.Objective, ObjectiveSearchObject, ObjectiveInsertRequest, ObjectiveUpdateRequest>, IObjectivesService
    {
        public ObjectivesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
