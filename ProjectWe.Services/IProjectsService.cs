using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectWe.Model;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;

namespace ProjectWe.Services
{
    public interface IProjectsService : ICRUDService<Model.Project, ProjectSearchObject, ProjectInsertRequest, ProjectUpdateRequest>
    {
    }
}
