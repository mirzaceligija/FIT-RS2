using ProjectWe.Model;
using ProjectWe.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public interface IOutputsService : ICRUDService<Model.Output, OutputSearchObject, OutputInsertRequest, OutputUpdateRequest>
    {
    }
}
