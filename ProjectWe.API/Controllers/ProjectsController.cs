using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Model;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.Controllers
{
    public class ProjectsController : BaseCRUDController<Project, ProjectSearchObject, ProjectInsertRequest, ProjectUpdateRequest>
    {
        public IProjectsService ProjectsService { get; set; }
        public ProjectsController(IProjectsService service) : base(service)
        {
            ProjectsService = service;
        }

        [Authorize("Manager")]
        public override Model.Project Insert([FromBody] ProjectInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize("Manager")]
        public override Model.Project Update(int id, [FromBody] ProjectUpdateRequest update)
        {
            return base.Update(id, update);
        }

        [Authorize("Administrator")]
        [HttpPut("{id}/Activate")]
        public Model.Project Activate(int id)
        {
            var result = ProjectsService.Activate(id);
            return result;
        }

        [HttpPut("{id}/AllowedActions")]
        public List<string> AllowedActions(int id)
        {
            var result = ProjectsService.AllowedActions(id);
            return result;
        }
    }
}
