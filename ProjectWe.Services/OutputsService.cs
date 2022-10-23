using AutoMapper;
using ProjectWe.Model;
using ProjectWe.Model.Requests;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class OutputsService : BaseCRUDService<Model.Output, Database.Output, OutputSearchObject, OutputInsertRequest, OutputUpdateRequest>, IOutputsService
    {
        public OutputsService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
